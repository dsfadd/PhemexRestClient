using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PhemexClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhemexRestClient.Models;

namespace PhemexRestClient.Converters
{
    internal class USDTMOrderBookConverter : JsonConverter<Orderbook_P>
    {
        public override Orderbook_P ReadJson(JsonReader reader, Type objectType, Orderbook_P existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);

            var book = new Orderbook_P
            {
                asks = jsonObject["asks"]?.ToObject<List<List<decimal>>>(serializer)
                    .Select(x => new USDTMAsk { priceRp = x[0], size = x[1] }).ToList(),

                bids = jsonObject["bids"]?.ToObject<List<List<decimal>>>(serializer)
                    .Select(x => new USDTMBid { priceRp = x[0], size = x[1] }).ToList()
            };

            return book;
        }

        public override void WriteJson(JsonWriter writer, Orderbook_P value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // Не требуется для десериализации
        }
    }
}
