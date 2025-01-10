using CryptoExchange.Net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Objects
{
    internal class PhemexResult<T>
    {

        [JsonProperty("code")]
        public int? Code { get; set; }
        [JsonProperty("msg")]
        public string? Message { get; set; }

#pragma warning disable 8618
        [JsonProperty("result")]
        public T Result { get; set; }
#pragma warning restore
    }

    internal class PhemexResultWithData<T>
    {

        [JsonProperty("code")]
        public int? Code { get; set; }
        [JsonProperty("msg")]
        public string? Message { get; set; }


#pragma warning disable 8618
        [JsonProperty("data")]
        public T Data { get; set; }
#pragma warning restore
    }

    internal class PhemexMDResult<T>
    {
        [JsonProperty("error")]
        public Error error { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }

#pragma warning disable 8618
        [JsonProperty("result")]
        public T Result { get; set; }
#pragma warning restore
    }
    internal class Error
    {
        public int code { get; set; }
        public string message { get; set; }
    }
}
