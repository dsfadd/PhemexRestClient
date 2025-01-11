using Newtonsoft.Json;
using PhemexClient.Converters;
using PhemexRestClient.Enums;

namespace PhemexClient.Models
{
    //rename
    public class PhemexRecentTrade
    {
        public string type { get; set; }
        public long sequence { get; set; }
        public string symbol { get; set; }
        [JsonConverter(typeof(TradeInfoConverter))]
        public List<PhemexTradeInfo> trades { get; set; }

      
    }
    public class PhemexTradeInfo
    {
       public long timestamp { get; set; }
       public OrderSide side { get; set; }
        public long priceEP { get; set; }
        public long size { get; set; }


    }
}
