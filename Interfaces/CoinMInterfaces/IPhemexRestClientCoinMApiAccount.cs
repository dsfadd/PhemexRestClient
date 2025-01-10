using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using PhemexRestClient.Models;
using System.Security.Principal;

namespace PhemexClient.Interfaces.CoinMInterfaces
{
    public interface IPhemexRestClientCoinMApiAccount
    {
        public Task<WebCallResult<PhemexAccountAndPositions>> GetTradingAccountAndPositionsAsync(string currency,CancellationToken cancellationToken=default);
    }
}