using CryptoExchange.Net.Objects;
using CryptoExchange.Net;
using PhemexClient.Models;
using PhemexClient.SpotApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhemexClient.Interfaces.ContractInterfaces;

namespace PhemexClient.ContractApi
{
    internal class PhemexRestClientContractApiAccount :IPhemexRestClientContractApiAccount
    {
        private PhemexRestClientContractApi _baseClient;
        public PhemexRestClientContractApiAccount(PhemexRestClientContractApi baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<WebCallResult<IEnumerable<PhemexSpotWallet>>> GetBalancesAsync(string? currency = null, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("currency", currency);

            return await _baseClient.SendRequestAsync<IEnumerable<PhemexSpotWallet>>("/spot/wallets", HttpMethod.Get, cancellationToken, signed: true).ConfigureAwait(false);

        }

    }
}
