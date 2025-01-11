using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Models
{

  
    public class Result
    {
        public int depth { get; set; }
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
        public long priceRp { get; set; }
        public long size { get; set; }
    }
    public class USDTMAsk
    {
        public long priceRp { get; set; }
        public long size { get; set; }

    }

}
