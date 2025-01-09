using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PhemexClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Converters
{


    public class ProductConverter : JsonConverter<ProductBase[]>
    {

        public override ProductBase[]? ReadJson(JsonReader reader, Type objectType, ProductBase[]? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var products = new List<ProductBase>();

            foreach (var item in jsonArray)
            {
                // Логируем тип продукта
                var type = item["type"]?.ToString();

                if (type == "Spot")
                {
                    var spotProduct = item.ToObject<PhemexSpotProduct>(serializer);
                    products.Add(spotProduct);
                }
                else if (type == "Perpetual")
                {
                    var perpetualProduct = item.ToObject<PhemexPerpetualProduct>(serializer);
                    products.Add(perpetualProduct);
                }
                else
                {
                    throw new NotSupportedException($"Unsupported product type: {type}");
                }
            }

            return products.ToArray();
        }


        public override void WriteJson(JsonWriter writer, ProductBase[]? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

}
