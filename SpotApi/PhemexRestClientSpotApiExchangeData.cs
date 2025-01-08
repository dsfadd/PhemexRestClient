using CryptoExchange.Net.CommonObjects;
using CryptoExchange.Net.Objects;
using PhemexClient.Interfaces.SpotInterfaces;
using PhemexClient.Models;
using System.Threading;

namespace PhemexClient.SpotApi
{
    internal class PhemexRestClientSpotApiExchangeData : IPhemexRestClientSpotApiExchangeData
    {
        private PhemexRestClientSpotApi _baseClient;
        public PhemexRestClientSpotApiExchangeData(PhemexRestClientSpotApi baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<WebCallResult<PhemexOrderBook>> GetOrderBookAsync(string symbol ,CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol }
             };
            return await _baseClient.SendMDRequestAsync<PhemexOrderBook>("/md/orderbook", HttpMethod.Get, cancellationToken, parameters);
        }


        public async Task<WebCallResult<PhemexSpotTrade>> GetRecentTradesAsync(string symbol, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol }
             };
            return await _baseClient.SendMDRequestAsync<PhemexSpotTrade>("/md/trade", HttpMethod.Get, cancellationToken, parameters);
        }

        public async Task<IEnumerable<ProductBase>> GetSymbolsAsync(CancellationToken cancellationToken = default)
        {
            var ExchangeInfoCallResult=await _baseClient.GetExchangeInfoAsync(cancellationToken);
            if (!(ExchangeInfoCallResult && ExchangeInfoCallResult.Data != null)) return null;
               return ExchangeInfoCallResult.Data.products.Where(product=>product.type==Enums.ProductType.Spot);
        }

        public async Task<WebCallResult<PhemexSpotTicker>> GetTickersAsync(string symbol, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol }
             };
            return await  _baseClient.SendMDRequestAsync<PhemexSpotTicker>("/md/spot/ticker/24hr", HttpMethod.Get, cancellationToken,parameters);
        }
        public async Task<WebCallResult<IEnumerable<PhemexSpotTicker>>> GetTickersAsync( CancellationToken cancellationToken = default)
        {
            return await _baseClient.SendMDRequestAsync<IEnumerable<PhemexSpotTicker>>("/md/spot/ticker/24hr/all", HttpMethod.Get, cancellationToken);
        }
    }
}