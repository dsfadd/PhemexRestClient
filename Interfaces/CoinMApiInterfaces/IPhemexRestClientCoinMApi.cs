using CryptoExchange.Net.Interfaces.CommonClients;
using CryptoExchange.Net.Interfaces;
using PhemexClient.Interfaces.SpotInterfaces;


namespace PhemexClient.Interfaces.CoinMInterfaces
{
    public interface IPhemexRestClientCoinMApi : IRestApiClient, IDisposable
    {
        /// <summary>
        /// Endpoints related to account settings, info or actions
        /// </summary>
       public IPhemexRestClientCoinMApiAccount Account { get; }

        /// <summary>
        /// Endpoints related to retrieving market and system data
        /// </summary>
       public IPhemexRestClientCoinMApiExchangeData ExchangeData { get; }

        /// <summary>
        /// Endpoints related to orders and trades
        /// </summary>
      public  IPhemexRestClientCoinMApiTrading Trading { get; }

        /// <summary>
        /// DEPRECATED; use <see cref="CryptoExchange.Net.SharedApis.ISharedClient" /> instead for common/shared functionality. See <see href="https://jkorf.github.io/CryptoExchange.Net/docs/index.html#shared" /> for more info.
        /// </summary>
        public ISpotClient CommonSpotClient { get; }
    }
}
