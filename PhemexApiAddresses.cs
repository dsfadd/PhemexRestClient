using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient
{
    public class PhemexApiAddresses
    {
        /// <summary>
        /// Rest API base address
        /// </summary>
        public string RestBaseAddress { get; set; } = "";
        /// <summary>
        /// Socket API base address
        /// </summary>
        public string SocketBaseAddress { get; set; } = "";

        /// <summary>
        /// The default addresses to connect to the Bybit.com API
        /// </summary>
        public static PhemexApiAddresses Default = new PhemexApiAddresses
        {
            RestBaseAddress = "https://api.phemex.com",
            SocketBaseAddress = "wss://vapi.phemex.com/ws"
        };

        /// <summary>
        /// The addresses to connect to the Bybit testnet
        /// </summary>
        public static PhemexApiAddresses TestNet = new PhemexApiAddresses
        {
            RestBaseAddress = "https://testnet-api.phemex.com",
            SocketBaseAddress = "wss://testnet-api.phemex.com/ws",
        };

    }
}
