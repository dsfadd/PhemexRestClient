using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Interfaces.CommonClients;
using PhemexClient.Interfaces.ContractInterfaces;
using PhemexClient.Interfaces.SpotInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Interfaces
{
    public interface IPhemexRestClient
    {
        public IPhemexRestClientSpotApi SpotApi { get; }
        public IPhemexRestClientContractApi ContractApi { get; }
    }

   
}
