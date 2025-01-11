using CryptoExchange.Net.Objects;
using PhemexRestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Interfaces.USDTmApiInterfaces
{
    public interface IPhemexRestClientUSDTMApiAccount
    {
            public Task<WebCallResult<PhemexUSDTMAccountAndPositions>> GetTradingAccountAndPositionsAsync(string currency, CancellationToken cancellationToken = default);
    }
}
