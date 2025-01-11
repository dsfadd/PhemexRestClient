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
        public int sequence { get; set; }
        public string symbol { get; set; }
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
