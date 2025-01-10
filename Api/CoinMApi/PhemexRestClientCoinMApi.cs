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
using PhemexRestClient.Api.SpotApi;


namespace PhemexRestClient.Api.CoinMApi
{
    internal class PhemexRestClientCoinMApi : RestApiClient, IPhemexRestClientCoinMApi
    {
        internal static TimeSyncState _timeSyncState = new TimeSyncState("CoinM Api");

        public IPhemexRestClientCoinMApiAccount Account {get;}

        public IPhemexRestClientCoinMApiExchangeData ExchangeData { get; }

        public IPhemexRestClientCoinMApiTrading Trading { get; }

        public ISpotClient CommonSpotClient { get; }



        internal PhemexRestClientCoinMApi(ILogger logger, HttpClient? httpClient, PhemexRestOptions options)
                : base(logger, httpClient, options.Environment.RestBaseAddress, options, options.CoinMOptions)
        {

           
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public override string FormatSymbol(string baseAsset, string quoteAsset, TradingMode tradingMode, DateTime? deliverDate = null)
        {
            throw new NotImplementedException();
        }

        public override TimeSpan? GetTimeOffset()
        {
            return _timeSyncState.TimeOffset;
        }

        public override TimeSyncInfo? GetTimeSyncInfo()
        {
            return new TimeSyncInfo(_logger, ApiOptions.AutoTimestamp ?? ClientOptions.AutoTimestamp, ApiOptions.TimestampRecalculationInterval ?? ClientOptions.TimestampRecalculationInterval, _timeSyncState);
        }

        public void SetApiCredentials<T>(T credentials) where T : ApiCredentials
        {
            throw new NotImplementedException();
        }

        public void SetOptions<T>(UpdateOptions<T> options) where T : ApiCredentials
        {
            throw new NotImplementedException();
        }

        protected override AuthenticationProvider CreateAuthenticationProvider(ApiCredentials credentials)
        => new PhemexAuthenticationProvider(credentials);
    }
}
