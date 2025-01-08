using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using PhemexClient.SpotApi;

namespace PhemexClient.Interfaces.SpotInterfaces
{
    public interface IPhemexRestClientSpotApiAccount
    {

        public Task<WebCallResult<IEnumerable<SpotWallet>>> GetBalancesAsync(string? currency = null, CancellationToken cancellationToken = default);
    }
}