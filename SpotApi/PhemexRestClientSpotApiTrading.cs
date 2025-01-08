using CryptoExchange.Net;
using CryptoExchange.Net.CommonObjects;
using CryptoExchange.Net.Converters.JsonNet;
using CryptoExchange.Net.Objects;
using PhemexClient.Enums;
using PhemexClient.Interfaces.SpotInterfaces;
using PhemexClient.Models;
using System.Drawing;
using System.Threading;

namespace PhemexClient.SpotApi
{
    internal class PhemexRestClientSpotApiTrading : IPhemexRestClientSpotApiTrading
    {


        private PhemexRestClientSpotApi _baseClient;
        public PhemexRestClientSpotApiTrading(PhemexRestClientSpotApi baseClient)
        {
            _baseClient = baseClient;
        }
        public async Task<WebCallResult<PhemexSpotOrder>> PlaceOrderAsync(string symbol,
            OrderSide side,
            QuantityType qtyType,
            string? quoteQtyRq = null,
            string? baseQtyRq = null,
            string? priceRp = null,
            string? stopPxRp = null,
            TriggerType? trigger = null,
            TimeInForceType? timeInForce = null,
            OrderType? ordType = null,
            bool? autoBorrow = null,
            string? borrowCurrency = null,
            string? borrowQtyRq = null,
            bool? autoPayback = null,
            string? paybackCurrency = null,
            string? paybackQtyRq = null,
            CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "Symbol", symbol },
                { "side", EnumConverter.GetString(side) },
                { "qtyType", EnumConverter.GetString(qtyType) },
             };
            #region OptinalParams
            parameters.AddOptionalParameter("quoteQtyRq", quoteQtyRq);
            parameters.AddOptionalParameter("baseQtyRq", baseQtyRq);
            parameters.AddOptionalParameter("priceRp", priceRp);
            parameters.AddOptionalParameter("stopPxRp", stopPxRp);
            parameters.AddOptionalParameter("trigger", EnumConverter.GetString(trigger));
            parameters.AddOptionalParameter("timeInForce", EnumConverter.GetString(timeInForce));
            parameters.AddOptionalParameter("ordType", EnumConverter.GetString(ordType));
            parameters.AddOptionalParameter("autoBorrow", autoBorrow);
            parameters.AddOptionalParameter("borrowCurrency", borrowCurrency);
            parameters.AddOptionalParameter("borrowQtyRq", borrowQtyRq);
            parameters.AddOptionalParameter("autoPayback", autoPayback);
            parameters.AddOptionalParameter("paybackCurrency", paybackCurrency);
            parameters.AddOptionalParameter("paybackQtyRq", paybackQtyRq);

            #endregion OptinalParams

            return await _baseClient.SendRequestAsync<PhemexSpotOrder>("/spot/orders/create", HttpMethod.Put, cancellationToken, parameters, signed: true).ConfigureAwait(false);
        }

        public async Task <WebCallResult<PhemexSpotOrder>> GetAllOpenOrdersAsync(string symbol,CancellationToken cancellationToken=default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol },

             };


            return await _baseClient.SendRequestAsync<PhemexSpotOrder>("/spot/orders", HttpMethod.Put, cancellationToken, parameters, signed: true).ConfigureAwait(false);
        }

        public async Task<WebCallResult<PhemexSpotOrderMini>> GetOrderAsync(string symbol, string? orderID = null, string? clOrdID = null, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol }
             };

            #region OptinalParams
            parameters.AddOptionalParameter("orderID", orderID);
            parameters.AddOptionalParameter("clOrdID", clOrdID);

            #endregion OptinalParams
            return await _baseClient.SendRequestAsync<PhemexSpotOrderMini>("/api-data/spots/orders", HttpMethod.Put, cancellationToken, parameters, signed: true).ConfigureAwait(false);
        }

    }



    



}
