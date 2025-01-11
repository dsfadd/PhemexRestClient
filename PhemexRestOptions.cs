using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Objects.Options;

namespace PhemexClient
{
    public class PhemexRestOptions : RestExchangeOptions<PhemexEnvironment, ApiCredentials>
    {

        internal static PhemexRestOptions Default { get; set; } = new PhemexRestOptions
        {
            Environment = PhemexEnvironment.Live
        };


        public PhemexRestOptions()
        {
            Default?.Set(this);
        }

        public string? Referer { get; set; }

        /// <summary>
        /// The default receive window for requests
        /// </summary>
        public TimeSpan ReceiveWindow { get; set; } = TimeSpan.FromSeconds(5);

        public RestApiOptions SpotOptions { get; private set; } = new RestApiOptions();
        public RestApiOptions CoinMOptions { get; private set; } = new RestApiOptions();
        public RestApiOptions USDTMOptions { get; private set; } = new RestApiOptions();



        internal PhemexRestOptions Set(PhemexRestOptions targetOptions)
        {
            targetOptions = base.Set<PhemexRestOptions>(targetOptions);
            targetOptions.Referer = Referer;
            targetOptions.ReceiveWindow = ReceiveWindow;
            targetOptions.SpotOptions = SpotOptions.Set(targetOptions.SpotOptions);
            targetOptions.CoinMOptions = CoinMOptions.Set(targetOptions.CoinMOptions);
            targetOptions.USDTMOptions = USDTMOptions.Set(targetOptions.USDTMOptions);
            return targetOptions;
        }
    }
}
