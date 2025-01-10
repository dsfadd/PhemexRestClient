using CryptoExchange.Net.CommonObjects;
using CryptoExchange.Net.Objects;
using PhemexClient.Models;

namespace PhemexClient.Interfaces.SpotInterfaces
{
    public interface IPhemexRestClientSpotApiExchangeData
    {

        public Task<WebCallResult<IEnumerable<PhemexSpotTicker>>> GetTickersAsync(CancellationToken cancellationToken = default);
        public Task<WebCallResult<PhemexSpotTicker>> GetTickersAsync(string symbol, CancellationToken cancellationToken = default);
        public Task<WebCallResult<PhemexRecentTrade>> GetRecentTradesAsync(string symbol, CancellationToken cancellationToken = default);

        public Task<IEnumerable<ProductBase>> GetSymbolsAsync(CancellationToken cancellationToken = default);

        public Task<WebCallResult<PhemexOrderBook>> GetOrderBookAsync(string symbol, CancellationToken cancellationToken = default);

    }
}