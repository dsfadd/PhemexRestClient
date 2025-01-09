using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Interfaces.CommonClients;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.SharedApis;
using Microsoft.Extensions.Logging;
using PhemexClient.Interfaces.SpotInterfaces;
using PhemexClient.Models;
using PhemexClient.Objects;

namespace PhemexClient.SpotApi
{
    internal class PhemexRestClientSpotApi : RestApiClient, IPhemexRestClientSpotApi
    {


        #region Api Clients
        public IPhemexRestClientSpotApiAccount Account  {get;}

        public IPhemexRestClientSpotApiExchangeData ExchangeData { get; }

        public IPhemexRestClientSpotApiTrading Trading { get; }



        #endregion

        #region _baseClient Functions

        internal Uri GetUri(string relativeUri) => new Uri(new Uri(BaseAddress), relativeUri);

        internal async Task<WebCallResult<T>> SendRequestAsync<T>(
            string endpoint,
            HttpMethod method,
            CancellationToken cancellationToken,
            Dictionary<string, object>? parameters = null,
            bool signed = false,
            bool ignoreRatelimit = false)
        {
                var result = await base.SendRequestAsync<PhemexResult<T>>(GetUri(endpoint), method, cancellationToken, parameters, signed, requestWeight: 0, parameterPosition: HttpMethodParameterPosition.InUri).ConfigureAwait(false);

                if (!result)
                    return result.As<T>(default);

                if (result.Data.Code != 0)
                    return result.AsError<T>(new ServerError(result.Data.Message ?? "", result.Data.Code));

                return result.As(result.Data.Result);
        }
        internal async Task<WebCallResult<T>> SendDataRequestAsync<T>(
           string endpoint,
           HttpMethod method,
           CancellationToken cancellationToken,
           Dictionary<string, object>? parameters = null,
           bool signed = false,
           bool ignoreRatelimit = false)
        {
            var result = await base.SendRequestAsync<PhemexResultWithData<T>>(GetUri(endpoint), method, cancellationToken, parameters, signed, requestWeight: 0, parameterPosition: HttpMethodParameterPosition.InUri).ConfigureAwait(false);

            if (!result)
                return result.As<T>(default);

            if (result.Data.Code != 0)
                return result.AsError<T>(new ServerError(result.Data.Message ?? "", result.Data.Code));

            return result.As(result.Data.Data);
        }

        internal async Task<WebCallResult<PhemexExchangeInfo>> GetExchangeInfoAsync(CancellationToken cancellationToken=default)
        {
           
            return await this.SendDataRequestAsync<PhemexExchangeInfo>("/public/products", HttpMethod.Get, cancellationToken);
        }


        internal async Task<WebCallResult<T>> SendMDRequestAsync<T>(
          string endpoint,
          HttpMethod method,
          CancellationToken cancellationToken,
          Dictionary<string, object>? parameters = null,
          bool signed = false,
          bool ignoreRatelimit = false)
        {
            var result = await base.SendRequestAsync<PhemexMDResult<T>>(GetUri(endpoint), method, cancellationToken, parameters, signed, requestWeight: 0, parameterPosition: HttpMethodParameterPosition.InUri).ConfigureAwait(false);
            if (!result)
                return result.As<T>(default);

            if (result.Data.error != null)
                return result.AsError<T>(new ServerError(result.Data.error.message ?? "", result.Data.error.code));

            return result.As(result.Data.Result);
        }

        #endregion
        internal PhemexRestClientSpotApi(ILogger logger, HttpClient? httpClient, PhemexRestOptions options)
           : base(logger, httpClient, options.Environment.RestBaseAddress, options, options.SpotOptions)
        {

            Account = new PhemexRestClientSpotApiAccount(this);
           ExchangeData = new PhemexRestClientSpotApiExchangeData(this);
            Trading = new PhemexRestClientSpotApiTrading(this);
        }
        public ISpotClient CommonSpotClient => throw new NotImplementedException();

        public override TimeSyncInfo? GetTimeSyncInfo()
        {
           return new TimeSyncInfo(_logger, (ApiOptions.AutoTimestamp ?? ClientOptions.AutoTimestamp), (ApiOptions.TimestampRecalculationInterval ?? ClientOptions.TimestampRecalculationInterval), _timeSyncState);

        }

        public override TimeSpan? GetTimeOffset()
        {
            return _timeSyncState.TimeOffset;
        }
        internal static TimeSyncState _timeSyncState = new TimeSyncState("Spot Api");
        protected override AuthenticationProvider CreateAuthenticationProvider(ApiCredentials credentials)
            => new PhemexAuthenticationProvider(credentials);

        public override string FormatSymbol(string baseAsset, string quoteAsset, TradingMode tradingMode, DateTime? deliverDate = null)
        {
            throw new NotImplementedException();
        }
    }

}
