using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Clients;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PhemexClient;
using PhemexClient.Interfaces;
using PhemexClient.Interfaces.ContractInterfaces;
using PhemexClient.Interfaces.SpotInterfaces;
using PhemexClient.SpotApi;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;

using static System.Net.WebRequestMethods;


public class PhemexRestClient : BaseRestClient, IPhemexRestClient
{

   public IPhemexRestClientSpotApi SpotApi { get; }

  public  IPhemexRestClientContractApi ContractApi { get; }
    #region constructor/destructor

    public PhemexRestClient(Action<PhemexRestOptions>? optionsDelegate = null)
        : this(null, null, Options.Create(ApplyOptionsDelegate(optionsDelegate)))
    {
    }


    public PhemexRestClient(HttpClient? httpClient, ILoggerFactory? loggerFactory, IOptions<PhemexRestOptions> options)
        : base(loggerFactory, "Phemex")
    {
        Initialize(options.Value);

        SpotApi = AddApiClient(new PhemexRestClientSpotApi(_logger, httpClient, options.Value));
        //ContractApi = AddApiClient(new BybitRestClientCopyTradingApi(_logger, httpClient, options.Value));

    }



    #endregion

    /// <summary>
    /// Set the default options to be used when creating new clients
    /// </summary>
    /// <param name="optionsDelegate">Option configuration delegate</param>
    public static void SetDefaultOptions(Action<PhemexRestOptions> optionsDelegate)
    {
        PhemexRestOptions.Default = ApplyOptionsDelegate(optionsDelegate);
    }

    /// <inheritdoc />
    public void SetApiCredentials(ApiCredentials credentials)
    {
        SpotApi.SetApiCredentials(credentials);
        ContractApi.SetApiCredentials(credentials);

    }
}

