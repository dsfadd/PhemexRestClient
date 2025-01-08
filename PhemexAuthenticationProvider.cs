using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net;

using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using CryptoExchange.Net.Clients;
using System.ComponentModel;
using System.Security.Cryptography;

namespace PhemexClient
{
    internal class PhemexAuthenticationProvider : AuthenticationProvider
    {
        public PhemexAuthenticationProvider(ApiCredentials credentials) : base(credentials)
        {
        }

        public override void AuthenticateRequest(
            RestApiClient apiClient,
            Uri uri,
            HttpMethod method,
            ref IDictionary<string, object>? uriParameters,
            ref IDictionary<string, object>? bodyParameters,
            ref Dictionary<string, string>? headers,
            bool auth,
            ArrayParametersSerialization arraySerialization,
            HttpMethodParameterPosition parameterPosition,
            RequestBodyFormat requestBodyFormat)
        {
            if (!auth)
                return;

            uriParameters ??= new Dictionary<string, object>();
            bodyParameters ??= new Dictionary<string, object>();
            headers ??= new Dictionary<string, string>();

            var expiryTimestamp = ((DateTimeOffset)DateTime.UtcNow.AddMinutes(1)).ToUnixTimeSeconds().ToString();
            string payload;

            var queryString = uriParameters.Count > 0 ? uri.SetParameters(uriParameters, arraySerialization).Query.Replace("?", "") : string.Empty;
            var bodyContent = bodyParameters.Count > 0 ? JsonConvert.SerializeObject(bodyParameters) : string.Empty;


            payload = uri.AbsolutePath + queryString + expiryTimestamp + bodyContent;

            var signature = SignHMACSHA256(payload);

            headers.Add("x-phemex-access-token", _credentials.Key!);
            headers.Add("x-phemex-request-expiry", expiryTimestamp);
            headers.Add("x-phemex-request-signature", signature);

            var tracingId = Guid.NewGuid().ToString("N").Substring(0, 32);
            ;
            headers.Add("x-phemex-request-tracing", tracingId);
        }

        private string SignHMACSHA256(string payload)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_credentials.Secret!));
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }


    internal class PhemexComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (string.Equals(x, "sign", StringComparison.Ordinal))
                return 1;
            if (string.Equals(y, "sign", StringComparison.Ordinal))
                return -1;

            return x.CompareTo(y);
        }
    }
}