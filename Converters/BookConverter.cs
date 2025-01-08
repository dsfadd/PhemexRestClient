using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhemexClient.Models;

namespace PhemexClient.Converters
{
    public class BookConverter : JsonConverter<Book>
    {
        public override Book ReadJson(JsonReader reader, Type objectType, Book existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);

            var book = new Book
            {
                asks = jsonObject["asks"]?.ToObject<List<List<long>>>(serializer)
                    .Select(x => new Ask { priceEP = x[0], size = x[1] }).ToList(),

                bids = jsonObject["bids"]?.ToObject<List<List<long>>>(serializer)
                    .Select(x => new Bid { priceEP = x[0], size = x[1] }).ToList()
            };

            return book;
        }

        public override void WriteJson(JsonWriter writer, Book value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // Не требуется для десериализации
        }
    }


}
