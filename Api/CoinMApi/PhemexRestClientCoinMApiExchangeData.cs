using CryptoExchange.Net.CommonObjects;
using CryptoExchange.Net.Objects;
using PhemexClient.Interfaces.CoinMInterfaces;
using PhemexClient.Models;
using PhemexRestClient.Api.Base;
using PhemexRestClient.Enums;
using PhemexRestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Api.CoinMApi
{
    internal class PhemexRestClientCoinMApiExchangeData : IPhemexRestClientCoinMApiExchangeData
    {
        private PhemexRestApiClientBase _baseClient;
        public PhemexRestClientCoinMApiExchangeData(PhemexRestApiClientBase baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<WebCallResult<PhemexOrderBook>> GetOrderBookAsync(string symbol, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol }
             };
            return await _baseClient.SendMDRequestAsync<PhemexOrderBook>("/md/orderbook", HttpMethod.Get, cancellationToken, parameters);
        }

        public async Task<WebCallResult<PhemexRecentTrade>> GetRecentTradesAsync(string symbol, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol }
             };
            return await _baseClient.SendMDRequestAsync<PhemexRecentTrade>("/md/trade", HttpMethod.Get, cancellationToken, parameters);
        }

        public async Task<IEnumerable<ProductBase>> GetSymbolsAsync(CancellationToken cancellationToken = default)
        {
            var ExchangeInfoCallResult = await _baseClient.GetExchangeInfoAsync(cancellationToken);
            return ExchangeInfoCallResult.Data.products.Where(product => product.type == ProductType.Perpetual);

        }

        public async Task<WebCallResult<IEnumerable<PhemexCoinMTicker>>> GetTickersAsync(CancellationToken cancellationToken = default)
        {

            return await _baseClient.SendMDRequestAsync<IEnumerable<PhemexCoinMTicker>>("/md/v1/ticker/24hr/all", HttpMethod.Get, cancellationToken);
        }

        public async Task<WebCallResult<PhemexCoinMTicker>> GetTickersAsync(string symbol, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
{
             { "symbol", symbol }
 };
            return await _baseClient.SendMDRequestAsync<PhemexCoinMTicker>("/md/v1/ticker/24hr", HttpMethod.Get, cancellationToken, parameters);
        }
    }

}
