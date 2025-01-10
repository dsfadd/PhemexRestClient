using PhemexRestClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Models
{


    public class PhemexMarginOrderInfo
    {
        public string orderID { get; set; }
        public string clOrdID { get; set; }
        public string priceRp { get; set; }
        public string action { get; set; }
        public string trigger { get; set; }
        public string pegPriceType { get; set; }
        public string stopDirection { get; set; }
        public long bizError { get; set; }
        public string symbol { get; set; }
        public OrderSide side { get; set; }
        public string baseQtyRq { get; set; }
        public OrderType ordType { get; set; }
        public TimeInForceType timeInForce { get; set; }
        public SpotOrderStatus ordStatus { get; set; }
        public string cumFeeRv { get; set; }
        public string cumBaseQtyRq { get; set; }
        public string cumQuoteQtyRq { get; set; }
        public string leavesBaseQtyRq { get; set; }
        public string leavesQuoteQtyRq { get; set; }
        public string avgPriceRp { get; set; }
        public string cumBaseAmountRv { get; set; }
        public string cumQuoteAmountRv { get; set; }
        public string quoteQtyRq { get; set; }
        public QuantityType qtyType { get; set; }
        public string stopPxRp { get; set; }
        public string pegOffsetValueRp { get; set; }
        public bool autoBorrow { get; set; }
        public long borrowCurrency { get; set; }
        public string borrowQtyRq { get; set; }
        public bool autoPayback { get; set; }
        public long paybackCurrency { get; set; }
        public string paybackPrincipalQtyRq { get; set; }
        public string paybackInterestQtyRq { get; set; }
        public string hourlyInterestRateRr { get; set; }
        public string riskLevelRr { get; set; }
        public string liqFeeRv { get; set; }
        public string liqFeeRateRr { get; set; }
    }


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

    public enum SpotOrderStatus
    {
        Untriggered,
        Triggered,
        Rejected,
        New,
        PartiallyFilled,
        Filled,
        Canceled

    }

 

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
