using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Models
{
    public class PhemexContractOrder
    {
        public long bizError { get; set; }
        public string orderID { get; set; }
        public string clOrdID { get; set; }
        public string symbol { get; set; }
        public string side { get; set; }
        public long actionTimeNs { get; set; }
        public long transactTimeNs { get; set; }
        public object orderType { get; set; }
        public long priceEp { get; set; }
        public long price { get; set; }
        public long orderQty { get; set; }
        public long displayQty { get; set; }
        public object timeInForce { get; set; }
        public bool reduceOnly { get; set; }
        public long stopPxEp { get; set; }
        public long closedPnlEv { get; set; }
        public long closedPnl { get; set; }
        public long closedSize { get; set; }
        public long cumQty { get; set; }
        public long cumValueEv { get; set; }
        public long cumValue { get; set; }
        public long leavesQty { get; set; }
        public long leavesValueEv { get; set; }
        public double leavesValue { get; set; }
        public long stopPx { get; set; }
        public string stopDirection { get; set; }
        public string ordStatus { get; set; }
    }
}
