using Newtonsoft.Json;
using PhemexClient.Converters;
using PhemexRestClient.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Models
{

  
    public class PhemexUSDTMOrderBook
    {
        public int depth { get; set; }
        [JsonConverter(typeof(USDTMOrderBookConverter))]
        public Orderbook_P orderbook_p { get; set; }
        public long sequence { get; set; }
        public string symbol { get; set; }
        public long timestamp { get; set; }
        public string type { get; set; }
    }

    public class Orderbook_P
    {
        public List<USDTMAsk> asks { get; set; }
        public List<USDTMBid> bids { get; set; }
    }

    public class USDTMBid
    {
        public decimal priceRp { get; set; }
        public decimal size { get; set; }
    }
    public class USDTMAsk
    {
        public decimal priceRp { get; set; }
        public decimal size { get; set; }

    }

}
