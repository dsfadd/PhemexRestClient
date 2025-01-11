using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using PhemexRestClient.Api.Base;
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

        public Task<WebCallResult<PhemexUSDTMRecentTradeInfo>> GetRecentTradesAsync(string symbol, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Perpproductsv2>> GetSymbolsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<WebCallResult<IEnumerable<PhemexUSDTMTicker>>> GetTickersAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<WebCallResult<PhemexUSDTMTicker>> GetTickersAsync(string symbol, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
