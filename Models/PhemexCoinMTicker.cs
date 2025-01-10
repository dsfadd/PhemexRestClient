using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Models
{

 

    public class PhemexCoinMTicker
    {
        public long askEp { get; set; }
        public long bidEp { get; set; }
        public long fundingRateEr { get; set; }
        public long highEp { get; set; }
        public long indexEp { get; set; }
        public long lastEp { get; set; }
        public long lowEp { get; set; }
        public long markEp { get; set; }
        public long openEp { get; set; }
        public long openInterest { get; set; }
        public long predFundingRateEr { get; set; }
        public string symbol { get; set; }
        public long timestamp { get; set; }
        public long turnoverEv { get; set; }
        public long volume { get; set; }
    }

}
