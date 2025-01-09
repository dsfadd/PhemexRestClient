using PhemexClient.Enums;
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
        public int bizError { get; set; }
        public string symbol { get; set; }
        public OrderSide side { get; set; }
        public string baseQtyRq { get; set; }
        public OrderType ordType { get; set; }
        public TimeInForceType timeInForce { get; set; }
        public OrderStatus ordStatus { get; set; }
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
        public int borrowCurrency { get; set; }
        public string borrowQtyRq { get; set; }
        public bool autoPayback { get; set; }
        public int paybackCurrency { get; set; }
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
        public OrderStatus ordStatus { get; set; }
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

    public enum OrderStatus
    {
        Created
    }

    public class PhemexSpotOrderByID
    {
        public int avgPriceEp { get; set; }
        public int avgTransactPriceEp { get; set; }
        public string baseQtyEv { get; set; }
        public int createTimeNs { get; set; }
        public int cumBaseValueEv { get; set; }
        public int cumFeeEv { get; set; }
        public int cumQuoteValueEv { get; set; }
        public string execStatus { get; set; }
        public string feeCurrency { get; set; }
        public int leavesBaseQtyEv { get; set; }
        public int leavesQuoteQtyEv { get; set; }
        public OrderStatus ordStatus { get; set; }
        public string ordType { get; set; }
        public string orderID { get; set; }
        public int priceEp { get; set; }
        public QuantityType qtyType { get; set; }
        public int quoteQtyEv { get; set; }
        public OrderSide side { get; set; }
        public string stopDirection { get; set; }
        public int stopPxEp { get; set; }
        public string symbol { get; set; }
        public TimeInForceType timeInForce { get; set; }
    }

}
