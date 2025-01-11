using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using PhemexRestClient.Api.Base;
using PhemexRestClient.Enums;
using PhemexRestClient.Interfaces.USDTmApiInterfaces;
using PhemexRestClient.Models;

namespace PhemexRestClient.Api.USDTMApi
{
    internal class PhemexRestClientUSDTMApiExchangeData : IPhemexRestClientUSDTMApiExchangeData
    {
        private PhemexRestApiClientBase _baseClient;
        public PhemexRestClientUSDTMApiExchangeData(PhemexRestApiClientBase baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<WebCallResult<PhemexUSDTMOrderBook>> GetOrderBookAsync(string symbol, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol }
             };
            return await _baseClient.SendMDRequestAsync<PhemexUSDTMOrderBook>("/md/v2/orderbook", HttpMethod.Get, cancellationToken, parameters);
        }

        public async Task<WebCallResult<PhemexUSDTMRecentTradeInfo>> GetRecentTradesAsync(string symbol, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol }
             };
            return await _baseClient.SendMDRequestAsync<PhemexUSDTMRecentTradeInfo>("/md/v2/trade", HttpMethod.Get, cancellationToken, parameters);
        }

        public async Task<IEnumerable<Perpproductsv2>> GetSymbolsAsync(CancellationToken cancellationToken = default)
        {
            var ExchangeInfoCallResult = await _baseClient.GetExchangeInfoAsync(cancellationToken);
            return ExchangeInfoCallResult.Data.perpProductsV2.Where(product => product.status =="Listed");
        }

        public async Task<WebCallResult<IEnumerable<PhemexUSDTMTicker>>> GetTickersAsync(CancellationToken cancellationToken = default)
        {
            return await _baseClient.SendMDRequestAsync<IEnumerable<PhemexUSDTMTicker>>("/md/v3/ticker/24hr/all", HttpMethod.Get, cancellationToken);
        }

        public async Task<WebCallResult<PhemexUSDTMTicker>> GetTickersAsync(string symbol, CancellationToken cancellationToken = default)
        {
            
             var parameters = new Dictionary<string, object>()
{
             { "symbol", symbol }
 };
            return await _baseClient.SendMDRequestAsync<PhemexUSDTMTicker>("/md/v3/ticker/24hr", HttpMethod.Get, cancellationToken, parameters);
        }
    }
}
