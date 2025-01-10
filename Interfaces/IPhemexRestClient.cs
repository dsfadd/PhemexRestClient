using PhemexClient.Interfaces.SpotInterfaces;

namespace PhemexClient.Interfaces
{
    public interface IPhemexRestClient
    {
        public IPhemexRestClientSpotApi SpotApi { get; }
        
    }

   
}
