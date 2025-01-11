using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Clients;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PhemexClient;
using PhemexClient.Interfaces;
using PhemexClient.Interfaces.CoinMInterfaces;
using PhemexClient.Interfaces.SpotInterfaces;
using PhemexRestClient.Api.CoinMApi;
using PhemexRestClient.Api.SpotApi;
using PhemexRestClient.Api.USDTMApi;
using PhemexRestClient.Interfaces.USDTmApiInterfaces;

namespace PhemexRestClient;
public class PhemexRestClient : BaseRestClient, IPhemexRestClient
{

   public IPhemexRestClientSpotApi SpotApi { get; }
    public IPhemexRestClientCoinMApi CoinMApi { get; }

    public IPhemexRestClientUSDTMApi USDTMApi { get; }

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
        CoinMApi = AddApiClient(new PhemexRestClientCoinMApi(_logger, httpClient, options.Value));
        USDTMApi = AddApiClient(new PhemexRestClientUSDTMApi(_logger, httpClient, options.Value));

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
        CoinMApi.SetApiCredentials(credentials);
        USDTMApi.SetApiCredentials(credentials);
    }
}

