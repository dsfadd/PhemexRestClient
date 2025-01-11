using Newtonsoft.Json;
using PhemexClient.Converters;
using PhemexRestClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Models
{



    public class PhemexUSDTMRecentTradeInfo
    {
        public long dts { get; set; }
        public long mts { get; set; }

        public long sequence { get; set; }
        public string symbol { get; set; }
        [JsonConverter(typeof(USDTMTradeConverter))]
        public List<PhemexUSDTMTrade> trades_p { get; set; }
        public string type { get; set; }
    }
    public class PhemexUSDTMTrade
    {
        public long timestamp { get; set; }
        public OrderSide Side { get; set; }
        public decimal PriceRp { get; set; }
        public decimal SizeRq { get; set; }
    }
}
