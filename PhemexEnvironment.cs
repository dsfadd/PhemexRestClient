using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient
{
    public class PhemexEnvironment : TradeEnvironment
    {
        public string RestBaseAddress { get; }

        /// <summary>
        /// Spot V1 Socket client address
        /// </summary>
        public string SocketBaseAddress { get; }

        internal PhemexEnvironment(string name,
            string restBaseAddress,
            string socketBaseAddress) : base(name)
        {
            RestBaseAddress = restBaseAddress;
            SocketBaseAddress = socketBaseAddress;
        }

        /// <summary>
        /// ctor for DI, use <see cref="CreateCustom"/> for creating a custom environment
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public PhemexEnvironment() : base(TradeEnvironmentNames.Live)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        { }

        /// <summary>
        /// Get the Bybit environment by name
        /// </summary>
        public static PhemexEnvironment? GetEnvironmentByName(string? name)
         => name switch
         {
             TradeEnvironmentNames.Live => Live,
             TradeEnvironmentNames.Testnet => Testnet,
             "" => Live,
             null => Live,
             _ => default
         };

        /// <summary>
        /// Live environment
        /// </summary>
        public static PhemexEnvironment Live { get; }
            = new PhemexEnvironment(TradeEnvironmentNames.Live,
                                     PhemexApiAddresses.Default.RestBaseAddress,
                                     PhemexApiAddresses.Default.SocketBaseAddress);

        /// <summary>
        /// Testnet environment
        /// </summary>
        public static PhemexEnvironment Testnet { get; }
            = new PhemexEnvironment(TradeEnvironmentNames.Testnet,
                                     PhemexApiAddresses.TestNet.RestBaseAddress,
                                     PhemexApiAddresses.TestNet.SocketBaseAddress);


        public static PhemexEnvironment CreateCustom(
                        string name,
                        string restAddress,
                        string socketAddress)
            => new PhemexEnvironment(name, restAddress, socketAddress);
    }
}
