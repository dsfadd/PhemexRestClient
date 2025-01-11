using CryptoExchange.Net.Interfaces;


namespace PhemexRestClient.Interfaces.USDTmApiInterfaces
{
    public interface IPhemexRestClientUSDTMApi:IRestApiClient, IDisposable
    {
        public IPhemexRestClientUSDTMApiExchangeData ExchangeData { get; }
        public IPhemexRestClientUSDTMApiAccount Account { get; }
    }
}
