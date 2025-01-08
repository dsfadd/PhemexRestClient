using CryptoExchange.Net.CommonObjects;
using CryptoExchange.Net;
using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhemexClient.Interfaces.SpotInterfaces;

namespace PhemexClient.SpotApi
{
    internal class PhemexRestClientSpotApiAccount : IPhemexRestClientSpotApiAccount
    {
        private PhemexRestClientSpotApi _baseClient;
        public PhemexRestClientSpotApiAccount(PhemexRestClientSpotApi baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<WebCallResult<IEnumerable<SpotWallet>>> GetBalancesAsync (string? currency = null,CancellationToken cancellationToken=default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("currency", currency);

            return await _baseClient.SendRequestAsync<IEnumerable<SpotWallet>>("/spot/wallets",HttpMethod.Get, cancellationToken, signed:true).ConfigureAwait(false);
           
        }


    }


}
