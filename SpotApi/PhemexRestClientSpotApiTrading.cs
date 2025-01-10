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

        public async Task<WebCallResult<PhemexSpotOrderByID>> GetOrderByIDAsync(string symbol, string? orderID = null, string? clOrdID = null, CancellationToken cancellationToken = default)
        {
            if (orderID is null && clOrdID is null) throw new ArgumentNullException(nameof(orderID)+nameof(clOrdID));
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol },
             };
            parameters.AddOptionalParameter("orderID", orderID);
            parameters.AddOptionalParameter("clOrdID", clOrdID);
            return await _baseClient.SendDataRequestAsync<PhemexSpotOrderByID>("/api-data/spots/orders/by-order-id", HttpMethod.Get, cancellationToken, parameters, signed: true).ConfigureAwait(false);
            
        }

        public async Task<WebCallResult<PhemexMarginOrderInfo>> PlaceMarginOrderAsync(string symbol,
            OrderSide side,
            QuantityType qtyType,
            string priceRp,
            string? quoteQtyRq = null,
            string? baseQtyRq = null,
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
            if (priceRp == null) throw new ArgumentNullException(nameof(priceRp));
            if (qtyType == QuantityType.ByBase && baseQtyRq == null) throw new ArgumentNullException(nameof(baseQtyRq));
            if (qtyType == QuantityType.ByQuote && quoteQtyRq == null) throw new ArgumentNullException(nameof(quoteQtyRq));

            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol },
                { "side", EnumConverter.GetString(side) },
                { "qtyType", EnumConverter.GetString(qtyType) },
                { "priceRp",priceRp }
             };

            
            #region OptinalParams
            parameters.AddOptionalParameter("quoteQtyRq", quoteQtyRq);
            parameters.AddOptionalParameter("baseQtyRq", baseQtyRq);
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

            return await _baseClient.SendDataRequestAsync<PhemexMarginOrderInfo>("/margin-trade/orders/create", HttpMethod.Put, cancellationToken, parameters, signed: true).ConfigureAwait(false);
        }

        public async Task<WebCallResult<PhemexSpotOrderInfo>> PlaceOrderAsync(string symbol,
            OrderSide side,
            QuantityType qtyType,
            string priceEp,
            string? quoteQtyEv = null, 
            string? baseQtyEv = null, 
            string? stopPxEp = null,
            TriggerType? trigger = null, 
            TimeInForceType? timeInForce = null,
            OrderType? ordType = null,
            CancellationToken cancellationToken = default)
        {
            if (priceEp==null) throw new ArgumentNullException(nameof(priceEp));
            if (qtyType == QuantityType.ByBase && baseQtyEv == null) throw new ArgumentNullException(nameof(baseQtyEv));
            if (qtyType == QuantityType.ByQuote && quoteQtyEv == null) throw new ArgumentNullException(nameof(quoteQtyEv));
            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol },
                { "side", EnumConverter.GetString(side) },
                { "qtyType", EnumConverter.GetString(qtyType) },
                { "priceEp", priceEp}
             };

            #region OptinalParams
            parameters.AddOptionalParameter("quoteQtyEv", quoteQtyEv);
            parameters.AddOptionalParameter("baseQtyEv", baseQtyEv);
            parameters.AddOptionalParameter("stopPxEp", stopPxEp);
            parameters.AddOptionalParameter("trigger", EnumConverter.GetString(trigger));
            parameters.AddOptionalParameter("timeInForce", EnumConverter.GetString(timeInForce));
            parameters.AddOptionalParameter("ordType", EnumConverter.GetString(ordType));

            #endregion OptinalParams
            return await _baseClient.SendDataRequestAsync<PhemexSpotOrderInfo>("/spot/orders/create", HttpMethod.Put, cancellationToken, parameters, signed: true).ConfigureAwait(false);
        }
    }



    



}
