using PhemexRestClient.Enums;

namespace PhemexClient.Models
{
    public class PhemexSpotOrderByID
    {
        public long avgPriceEp { get; set; }
        public long avgTransactPriceEp { get; set; }
        public string baseQtyEv { get; set; }
        public long createTimeNs { get; set; }
        public long cumBaseValueEv { get; set; }
        public long cumFeeEv { get; set; }
        public long cumQuoteValueEv { get; set; }
        public string execStatus { get; set; }
        public string feeCurrency { get; set; }
        public long leavesBaseQtyEv { get; set; }
        public long leavesQuoteQtyEv { get; set; }
        public SpotOrderStatus ordStatus { get; set; }
        public OrderType ordType { get; set; }
        public string orderID { get; set; }
        public long priceEp { get; set; }
        public QuantityType qtyType { get; set; }
        public long quoteQtyEv { get; set; }
        public OrderSide side { get; set; }
        public string stopDirection { get; set; }
        public long stopPxEp { get; set; }
        public string symbol { get; set; }
        public TimeInForceType timeInForce { get; set; }
    }

}
