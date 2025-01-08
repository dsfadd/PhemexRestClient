using CryptoExchange.Net.Converters.JsonNet;
using Newtonsoft.Json;
using PhemexClient.Converters;
using PhemexClient.Enums;
using System;

namespace PhemexClient.Models
{

    public class ProductBase
    {
        public string symbol { get; set; }
        public int code { get; set; }
        [JsonConverter(typeof(EnumConverter))]
        public ProductType type { get; set; }
        public string displaySymbol { get; set; }
        public string quoteCurrency { get; set; }
        public int priceScale { get; set; }
        public int ratioScale { get; set; }
        public int pricePrecision { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public long tipOrderQty { get; set; }
        public long listTime { get; set; }
    }


    public class PhemexPerpetualProduct : ProductBase
    {
        public string indexSymbol { get; set; }
        public string markSymbol { get; set; }
        public string fundingRateSymbol { get; set; }
        public string fundingRate8hSymbol { get; set; }
        public string contractUnderlyingAssets { get; set; }
        public string settleCurrency { get; set; }
        public int contractSize { get; set; }
        public int lotSize { get; set; }
        public double tickSize { get; set; }
        public long minPriceEp { get; set; }
        public long maxPriceEp { get; set; }
        public int maxOrderQty { get; set; }
        public bool majorSymbol { get; set; }
        public string defaultLeverage { get; set; }
        public int fundingInterval { get; set; }
        public int maxLeverage { get; set; }
        public int leverageMargin { get; set; }
    }

    public class PhemexSpotProduct : ProductBase
    {
        public string baseCurrency { get; set; }
        public string baseTickSize { get; set; }
        public int baseTickSizeEv { get; set; }
        public string quoteTickSize { get; set; }
        public int quoteTickSizeEv { get; set; }
        public int baseQtyPrecision { get; set; }
        public int quoteQtyPrecision { get; set; }
        public string minOrderValue { get; set; }
        public int minOrderValueEv { get; set; }
        public string maxBaseOrderSize { get; set; }
        public long maxBaseOrderSizeEv { get; set; }
        public string maxOrderValue { get; set; }
        public long maxOrderValueEv { get; set; }
        public string defaultTakerFee { get; set; }
        public int defaultTakerFeeEr { get; set; }
        public string defaultMakerFee { get; set; }
        public int defaultMakerFeeEr { get; set; }
        public long ieoOpenPriceEp { get; set; }
        public long ieoInitDurationMs { get; set; }
        public int buyPriceUpperLimitPct { get; set; }
        public int sellPriceLowerLimitPct { get; set; }

    }




    public class PhemexExchangeInfo
    {
        public Currency[] currencies { get; set; }

        [JsonConverter(typeof(ProductConverter))]
        public ProductBase[] products { get; set; }
        public Perpproductsv2[] perpProductsV2 { get; set; }
        public Risklimit[] riskLimits { get; set; }
        public Leverage[] leverages { get; set; }
        public Risklimitsv2[] riskLimitsV2 { get; set; }
        public Leveragesv2[] leveragesV2 { get; set; }
        public Leveragemargin[] leverageMargins { get; set; }
        public int ratioScale { get; set; }
        public string md5Checksum { get; set; }
    }

    public class Currency
    {
        public string currency { get; set; }
        public string name { get; set; }
        public int code { get; set; }
        public int valueScale { get; set; }
        public int minValueEv { get; set; }
        public long maxValueEv { get; set; }
        public int needAddrTag { get; set; }
        public string status { get; set; }
        public string displayCurrency { get; set; }
        public int inAssetsDisplay { get; set; }
        public int perpetual { get; set; }
        public int stableCoin { get; set; }
        public int assetsPrecision { get; set; }
    }

    

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

    public class Risklimit
    {
        public string symbol { get; set; }
        public string steps { get; set; }
        public Risklimit1[] riskLimits { get; set; }
    }

    public class Risklimit1
    {
        public int limit { get; set; }
        public string initialMargin { get; set; }
        public int initialMarginEr { get; set; }
        public string maintenanceMargin { get; set; }
        public int maintenanceMarginEr { get; set; }
    }

    public class Leverage
    {
        public string initialMargin { get; set; }
        public int initialMarginEr { get; set; }
        public float[] options { get; set; }
    }

    public class Risklimitsv2
    {
        public string symbol { get; set; }
        public string steps { get; set; }
        public Risklimit2[] riskLimits { get; set; }
    }

    public class Risklimit2
    {
        public int limit { get; set; }
        public string initialMarginRr { get; set; }
        public string maintenanceMarginRr { get; set; }
    }

    public class Leveragesv2
    {
        public int[] options { get; set; }
        public string initialMarginRr { get; set; }
    }

    public class Leveragemargin
    {
        public int index_id { get; set; }
        public Item[] items { get; set; }
    }

    public class Item
    {
        public int notionalValueRv { get; set; }
        public float maxLeverage { get; set; }
        public string maintenanceMarginRateRr { get; set; }
        public string maintenanceAmountRv { get; set; }
    }


}