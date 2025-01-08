using Newtonsoft.Json;
using PhemexClient.Enums;
using PhemexClient.Models;

namespace PhemexClient.Converters
{
    public class TradeInfoConverter : JsonConverter<List<PhemexTradeInfo>>
    {
        public override List<PhemexTradeInfo> ReadJson(JsonReader reader, Type objectType, List<PhemexTradeInfo> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var trades = new List<PhemexTradeInfo>();

            if (reader.TokenType == JsonToken.StartArray)
            {
                var array = serializer.Deserialize<List<List<object>>>(reader);
                foreach (var tradeArray in array)
                {
                    var trade = new PhemexTradeInfo
                    {
                        timestamp = Convert.ToInt64(tradeArray[0]),
                        side = Enum.Parse<OrderSide>(tradeArray[1].ToString(), true),
                        priceEP = Convert.ToInt64(tradeArray[2]),
                        size = Convert.ToInt64(tradeArray[3])
                    };
                    trades.Add(trade);
                }
            }

            return trades;
        }

        public override void WriteJson(JsonWriter writer, List<PhemexTradeInfo> value, JsonSerializer serializer)
        {
            throw new NotImplementedException("Serialization is not implemented");
        }
    }

    

}
