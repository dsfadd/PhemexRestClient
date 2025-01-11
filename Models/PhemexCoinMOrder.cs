using PhemexClient.Models;
using PhemexRestClient.Enums;

namespace PhemexRestClient.Models
{
    public class PhemexCoinMOrder
    {
        public int bizError { get; set; }
        public string orderID { get; set; }
        public string clOrdID { get; set; }
        public string symbol { get; set; }
        public OrderSide side { get; set; }
        public long actionTimeNs { get; set; }
        public int transactTimeNs { get; set; }
        public OrderType orderType { get; set; }
        public int priceEp { get; set; }
        public int price { get; set; }
        public int orderQty { get; set; }
        public int displayQty { get; set; }
        public TimeInForceType timeInForce { get; set; }
        public bool reduceOnly { get; set; }
        public int stopPxEp { get; set; }
        public int closedPnlEv { get; set; }
        public int closedPnl { get; set; }
        public int closedSize { get; set; }
        public int cumQty { get; set; }
        public int cumValueEv { get; set; }
        public int cumValue { get; set; }
        public int leavesQty { get; set; }
        public int leavesValueEv { get; set; }
        public float leavesValue { get; set; }
        public int stopPx { get; set; }
        public string stopDirection { get; set; }
        public SpotOrderStatus ordStatus { get; set; }
    }
}