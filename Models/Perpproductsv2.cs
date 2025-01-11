namespace PhemexClient.Models
{
    public class Perpproductsv2
    {
        public string symbol { get; set; }
        public int code { get; set; }
        public string type { get; set; }
        public string displaySymbol { get; set; }
        public string indexSymbol { get; set; }
        public string markSymbol { get; set; }
        public string fundingRateSymbol { get; set; }
        public string fundingRate8hSymbol { get; set; }
        public string contractUnderlyingAssets { get; set; }
        public string settleCurrency { get; set; }
        public string quoteCurrency { get; set; }
        public string tickSize { get; set; }
        public int priceScale { get; set; }
        public int ratioScale { get; set; }
        public int pricePrecision { get; set; }
        public string baseCurrency { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public int tipOrderQty { get; set; }
        public long listTime { get; set; }
        public bool majorSymbol { get; set; }
        public string defaultLeverage { get; set; }
        public int fundingInterval { get; set; }
        public int maxLeverage { get; set; }
        public int leverageMargin { get; set; }
        public string maxOrderQtyRq { get; set; }
        public string maxPriceRp { get; set; }
        public string minOrderValueRv { get; set; }
        public string minPriceRp { get; set; }
        public int qtyPrecision { get; set; }
        public string qtyStepSize { get; set; }
        public string tipOrderQtyRq { get; set; }
        public int maxOpenPosLeverage { get; set; }
    }


}