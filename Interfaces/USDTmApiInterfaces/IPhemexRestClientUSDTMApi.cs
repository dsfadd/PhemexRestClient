using CryptoExchange.Net.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Interfaces.USDTmApiInterfaces
{
    public interface IPhemexRestClientUSDTMApi:IRestApiClient, IDisposable
    {
        public IPhemexRestClientUSDTMApiExchangeData ExchangeData { get; }
    }
}
