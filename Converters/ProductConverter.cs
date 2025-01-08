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
                // Check for the "type" property to determine which specific product to deserialize
                var type = item["type"]?.ToString();

                if (type == "spot")
                {
                    // Deserialize as PhemexSpotProduct
                    var spotProduct = item.ToObject<PhemexSpotProduct>(serializer);
                    products.Add(spotProduct);
                }
                else if (type == "perpetual")
                {
                    // Deserialize as PhemexPerpetualProduct
                    var perpetualProduct = item.ToObject<PhemexPerpetualProduct>(serializer);
                    products.Add(perpetualProduct);
                }
                else
                {
                    // Handle unknown types or add a default case if necessary
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
