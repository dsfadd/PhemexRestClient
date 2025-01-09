using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using PhemexClient.SpotApi;

namespace PhemexClient.Interfaces.SpotInterfaces
{
    public interface IPhemexRestClientSpotApiAccount
    {

        public Task<WebCallResult<IEnumerable<PhemexSpotWallet>>> GetBalancesAsync(string? currency = null, CancellationToken cancellationToken = default);
    }
}