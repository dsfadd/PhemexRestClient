using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using PhemexRestClient.Api.Base;
using PhemexRestClient.Api.SpotApi;
using PhemexRestClient.Models;

namespace PhemexClient.Interfaces.CoinMInterfaces
{
    public interface IPhemexRestClientCoinMApiExchangeData
    {
        public Task<WebCallResult<PhemexRecentTrade>> GetRecentTradesAsync(string symbol, CancellationToken cancellationToken = default);
        public Task<WebCallResult<IEnumerable<PhemexCoinMTicker>>> GetTickersAsync(CancellationToken cancellationToken = default);
        public Task<WebCallResult<PhemexCoinMTicker>> GetTickersAsync(string symbol, CancellationToken cancellationToken = default);

        public Task<IEnumerable<ProductBase>> GetSymbolsAsync(CancellationToken cancellationToken = default);

        public Task<WebCallResult<PhemexOrderBook>> GetOrderBookAsync(string symbol, CancellationToken cancellationToken = default);
    }

    
}