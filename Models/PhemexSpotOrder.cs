using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Models
{
    public class PhemexSpotOrder
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
        public string side { get; set; }
        public long baseQtyEv { get; set; }
        public string ordType { get; set; }
        public string timeInForce { get; set; }
        public string ordStatus { get; set; }
        public long cumFeeEv { get; set; }
        public long cumBaseQtyEv { get; set; }
        public long cumQuoteQtyEv { get; set; }
        public long leavesBaseQtyEv { get; set; }
        public long leavesQuoteQtyEv { get; set; }
        public long avgPriceEp { get; set; }
        public long cumBaseAmountEv { get; set; }
        public long cumQuoteAmountEv { get; set; }
        public long quoteQtyEv { get; set; }
        public string qtyType { get; set; }
        public long stopPxEp { get; set; }
        public long pegOffsetValueEp { get; set; }
    }

    public class PhemexSpotOrderMini
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
        public string ordStatus { get; set; }
        public string ordType { get; set; }
        public string orderID { get; set; }
        public int priceEp { get; set; }
        public string qtyType { get; set; }
        public int quoteQtyEv { get; set; }
        public string side { get; set; }
        public string stopDirection { get; set; }
        public int stopPxEp { get; set; }
        public string symbol { get; set; }
        public string timeInForce { get; set; }
    }


}
