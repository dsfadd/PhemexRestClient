using PhemexClient.Interfaces.CoinMInterfaces;
using PhemexClient.Interfaces.SpotInterfaces;
using PhemexRestClient.Interfaces.USDTmApiInterfaces;

namespace PhemexClient.Interfaces
{
    public interface IPhemexRestClient
    {
        public IPhemexRestClientSpotApi SpotApi { get; }
        public IPhemexRestClientUSDTMApi USDTMApi { get; }
        public IPhemexRestClientCoinMApi CoinMApi { get; }


    }

   
}
