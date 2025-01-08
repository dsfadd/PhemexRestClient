using PhemexClient.Interfaces.ContractInterfaces;
using PhemexClient.SpotApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.ContractApi
{
    internal class PhemexRestClientContractApiExchangeData: IPhemexRestClientContractApiExchangeData
    {
        private PhemexRestClientContractApi _baseClient;
        public PhemexRestClientContractApiExchangeData(PhemexRestClientContractApi baseClient)
        {
            _baseClient = baseClient;
        }
    }
}
