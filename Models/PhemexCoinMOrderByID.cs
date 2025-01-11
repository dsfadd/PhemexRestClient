using PhemexRestClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Models
{
    public class PhemexCoinMOrderByID
    {
        public string orderID { get; set; }
        public string clOrdID { get; set; }
        public string symbol { get; set; }
        public OrderSide side { get; set; }
        public OrderType orderType { get; set; }
        public long actionTimeNs { get; set; }
        public long priceEp { get; set; }
        public object price { get; set; }
        public long orderQty { get; set; }
        public long displayQty { get; set; }
        public TimeInForceType timeInForce { get; set; }
        public bool reduceOnly { get; set; }
        public long takeProfitEp { get; set; }
        public object takeProfit { get; set; }
        public long stopLossEp { get; set; }
        public long closedPnlEv { get; set; }
        public object closedPnl { get; set; }
        public long closedSize { get; set; }
        public long cumQty { get; set; }
        public long cumValueEv { get; set; }
        public object cumValue { get; set; }
        public long leavesQty { get; set; }
        public long leavesValueEv { get; set; }
        public object leavesValue { get; set; }
        public object stopLoss { get; set; }
        public string stopDirection { get; set; }
        public SpotOrderStatus ordStatus { get; set; }
        public long transactTimeNs { get; set; }
    }
}
