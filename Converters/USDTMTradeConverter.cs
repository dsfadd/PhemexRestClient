using Newtonsoft.Json;
using PhemexRestClient.Enums;
using PhemexRestClient.Models;
using System.Globalization;

namespace PhemexClient.Converters
{
    public class USDTMTradeConverter : JsonConverter<List<PhemexUSDTMTrade>>
    {
        public override List<PhemexUSDTMTrade> ReadJson(JsonReader reader, Type objectType, List<PhemexUSDTMTrade> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var trades = new List<PhemexUSDTMTrade>();

            if (reader.TokenType == JsonToken.StartArray)
            {
                var array = serializer.Deserialize<List<List<object>>>(reader);
                foreach (var tradeArray in array)
                {
                    var trade = new PhemexUSDTMTrade
                    {
                        timestamp = Convert.ToInt64(tradeArray[0]),
                        Side = Enum.Parse<OrderSide>(tradeArray[1].ToString(), true),
                        PriceRp = Convert.ToDecimal(tradeArray[2], CultureInfo.InvariantCulture),
                        SizeRq = Convert.ToDecimal(tradeArray[3], CultureInfo.InvariantCulture)
                    };
                    trades.Add(trade);
                }
            }

            return trades;
        }

        public override void WriteJson(JsonWriter writer, List<PhemexUSDTMTrade> value, JsonSerializer serializer)
        {
            throw new NotImplementedException("Serialization is not implemented");
        }
    }

}
