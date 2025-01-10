using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Interfaces.CommonClients;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Objects.Options;
using CryptoExchange.Net.SharedApis;
using Microsoft.Extensions.Logging;
using PhemexClient;
using PhemexClient.Interfaces.CoinMInterfaces;
using PhemexRestClient.Api.Base;


namespace PhemexRestClient.Api.CoinMApi
{
    internal class PhemexRestClientCoinMApi : PhemexRestApiClientBase, IPhemexRestClientCoinMApi
    {
        internal static TimeSyncState _timeSyncState = new TimeSyncState("CoinM Api");

        public IPhemexRestClientCoinMApiAccount Account {get;}

        public IPhemexRestClientCoinMApiExchangeData ExchangeData { get; }

        public IPhemexRestClientCoinMApiTrading Trading { get; }

        public ISpotClient CommonSpotClient { get; }



        internal PhemexRestClientCoinMApi(ILogger logger, HttpClient? httpClient, PhemexRestOptions options)
                :base (logger, httpClient, options, options.CoinMOptions)
        {

            ExchangeData = new PhemexRestClientCoinMApiExchangeData(this);
            Account = new PhemexRestClientCoinMApiAccount(this);

        }

     
    }
}
