using PhemexRestClient.Enums;

namespace PhemexClient.Models
{
    public class PhemexSpotOrderInfo
    {
        public string orderID { get; set; }
        public string clOrdID { get; set; }
        public long priceEp { get; set; }
        public string action { get; set; }
        public string trigger { get; set; }
        public string pegPriceType { get; set; }
        public string stopDirection { get; set; }
        public long bizError { get; set; }
        public string symbol { get; set; }
        public OrderSide side { get; set; }
        public long baseQtyEv { get; set; }
        public OrderType ordType { get; set; }
        public TimeInForceType timeInForce { get; set; }
        public SpotOrderStatus ordStatus { get; set; }
        public long cumFeeEv { get; set; }
        public long cumBaseQtyEv { get; set; }
        public long cumQuoteQtyEv { get; set; }
        public long leavesBaseQtyEv { get; set; }
        public long leavesQuoteQtyEv { get; set; }
        public long avgPriceEp { get; set; }
        public long cumBaseAmountEv { get; set; }
        public long cumQuoteAmountEv { get; set; }
        public long quoteQtyEv { get; set; }
        public QuantityType qtyType { get; set; }
        public long stopPxEp { get; set; }
        public long pegOffsetValueEp { get; set; }
    }

}
