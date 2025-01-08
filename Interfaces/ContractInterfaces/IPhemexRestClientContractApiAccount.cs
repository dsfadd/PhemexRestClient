using CryptoExchange.Net.Objects;
using PhemexClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Interfaces.ContractInterfaces
{
    public interface IPhemexRestClientContractApiAccount
    {
        public  Task<WebCallResult<IEnumerable<SpotWallet>>> GetBalancesAsync(string? currency = null, CancellationToken cancellationToken = default);
    }
}
