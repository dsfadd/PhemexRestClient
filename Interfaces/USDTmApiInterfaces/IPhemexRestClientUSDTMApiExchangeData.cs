using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using PhemexRestClient.Models;


namespace PhemexRestClient.Interfaces.USDTmApiInterfaces
{
    public interface IPhemexRestClientUSDTMApiExchangeData
    {
        public Task<WebCallResult<IEnumerable<PhemexUSDTMTicker>>> GetTickersAsync(CancellationToken cancellationToken = default);
        public Task<WebCallResult<PhemexUSDTMTicker>> GetTickersAsync(string symbol,CancellationToken cancellationToken = default);
        public Task<IEnumerable<Perpproductsv2>> GetSymbolsAsync(CancellationToken cancellationToken = default);
        public Task<WebCallResult<PhemexUSDTMOrderBook>> GetOrderBookAsync(string symbol, CancellationToken cancellationToken = default);

        public Task<WebCallResult<PhemexUSDTMRecentTradeInfo>> GetRecentTradesAsync(string symbol, CancellationToken cancellationToken = default);
    }
}
