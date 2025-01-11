using CryptoExchange.Net.Objects.Options;
using Microsoft.Extensions.Logging;
using PhemexClient;
using PhemexRestClient.Api.Base;
using PhemexRestClient.Interfaces.USDTmApiInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Api.USDTMApi
{
    internal class PhemexRestClientUSDTMApi :PhemexRestApiClientBase, IPhemexRestClientUSDTMApi
    {
        public IPhemexRestClientUSDTMApiExchangeData ExchangeData { get; }

        internal PhemexRestClientUSDTMApi(ILogger logger, HttpClient? httpClient, PhemexRestOptions options) 
            : base(logger, httpClient, options, options.USDTMOptions)
        {
            ExchangeData = new PhemexRestClientUSDTMApiExchangeData(this);
        }

        
    }
}
