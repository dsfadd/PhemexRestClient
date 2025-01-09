using CryptoExchange.Net;
using CryptoExchange.Net.Objects;
using PhemexClient.Interfaces.SpotInterfaces;
using PhemexClient.Models;

namespace PhemexClient.SpotApi
{
    internal class PhemexRestClientSpotApiAccount : IPhemexRestClientSpotApiAccount
    {
        private PhemexRestClientSpotApi _baseClient;
        public PhemexRestClientSpotApiAccount(PhemexRestClientSpotApi baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<WebCallResult<IEnumerable<PhemexSpotWallet>>> GetBalancesAsync (string? currency = null,CancellationToken cancellationToken=default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("currency", currency);

            return await _baseClient.SendDataRequestAsync<IEnumerable<PhemexSpotWallet>>("/spot/wallets",HttpMethod.Get, cancellationToken, signed:true).ConfigureAwait(false);
           
        }


    }


}
