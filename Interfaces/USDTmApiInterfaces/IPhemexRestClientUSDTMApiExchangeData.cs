using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using PhemexRestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Interfaces.USDTmApiInterfaces
{
    public interface IPhemexRestClientUSDTMApiExchangeData
    {
        public Task<WebCallResult<IEnumerable<PhemexUSDTMTicker>>> GetTickersAsync(CancellationToken cancellationToken = default);
        public Task<WebCallResult<PhemexUSDTMTicker>> GetTickersAsync(string symbol,CancellationToken cancellationToken = default);
        public Task<IEnumerable<Perpproductsv2>> GetSymbolsAsync(CancellationToken cancellationToken = default);
        public Task<WebCallResult<PhemexOrderBook>> GetOrderBookAsync(string symbol, CancellationToken cancellationToken = default);
    }
}
