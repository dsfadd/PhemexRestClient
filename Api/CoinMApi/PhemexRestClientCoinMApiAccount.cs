
using CryptoExchange.Net.Objects;
using PhemexClient.Interfaces.CoinMInterfaces;
using PhemexRestClient.Api.Base;
using PhemexRestClient.Models;

namespace PhemexRestClient.Api.CoinMApi
{
    internal class PhemexRestClientCoinMApiAccount: IPhemexRestClientCoinMApiAccount
    {
        private PhemexRestApiClientBase _baseClient;
        public PhemexRestClientCoinMApiAccount(PhemexRestApiClientBase baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<WebCallResult<PhemexAccountAndPositions>> GetTradingAccountAndPositionsAsync(string currency, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "currency", currency }
             };
            return await _baseClient.SendDataRequestAsync<PhemexAccountAndPositions>("/accounts/accountPositions", HttpMethod.Get, cancellationToken, parameters,signed:true);
        }
    }
}
