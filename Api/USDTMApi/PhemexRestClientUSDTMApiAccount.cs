using CryptoExchange.Net;
using CryptoExchange.Net.Clients;
using CryptoExchange.Net.Objects;
using PhemexRestClient.Api.Base;
using PhemexRestClient.Interfaces.USDTmApiInterfaces;
using PhemexRestClient.Models;


namespace PhemexRestClient.Api.USDTMApi
{
    internal class PhemexRestClientUSDTMApiAccount : IPhemexRestClientUSDTMApiAccount
    {
        private PhemexRestApiClientBase _baseClient;
        public PhemexRestClientUSDTMApiAccount(PhemexRestApiClientBase baseClient)
        {
            _baseClient = baseClient;
        }
        public async Task<WebCallResult<PhemexUSDTMAccountAndPositions>> GetTradingAccountAndPositionsAsync(string currency,string? symbol=null, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "currency", currency }
             };

            parameters.AddOptionalParameter("symbol", symbol);
            return await _baseClient.SendDataRequestAsync<PhemexUSDTMAccountAndPositions>("/g-accounts/accountPositions", HttpMethod.Get, cancellationToken, parameters, signed: true);
        }
    }
}
