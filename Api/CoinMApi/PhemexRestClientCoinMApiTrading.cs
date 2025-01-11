using CryptoExchange.Net;
using CryptoExchange.Net.Converters.JsonNet;
using CryptoExchange.Net.Objects;
using PhemexClient.Interfaces.CoinMInterfaces;
using PhemexRestClient.Api.Base;
using PhemexRestClient.Enums;
using PhemexRestClient.Models;

namespace PhemexRestClient.Api.CoinMApi
{
    internal class PhemexRestClientCoinMApiTrading : IPhemexRestClientCoinMApiTrading
    {

        private PhemexRestApiClientBase _baseClient;
        public PhemexRestClientCoinMApiTrading(PhemexRestApiClientBase baseClient)
        {
            _baseClient = baseClient;
        }


        public async Task<WebCallResult<PhemexCoinMOrder>> PlaceOrderAsync(string symbol, 
            string clOrdID,
            OrderSide side,
            long orderQty, 
            long? priceEp = null,
            OrderType? ordType = null,
            long? stopPxEp = null,
            TimeInForceType? timeInForce = null,
            bool? reduceOnly = null,
            bool? closeOnTrigger = null,
            TriggerType? triggerType = null,
            long? takeProfitEp = null,
            long? stopLossEp = null,
            TriggerType? slTrigger = null, 
            TriggerType? tpTrigger = null,
            long? pegOffsetValueEp = null, 
            TrailingOrderPriceType? pegPriceType = null,
            CancellationToken cancellationToken = default)
        {
            if (ordType==OrderType.Limit&& priceEp==null) throw new ArgumentNullException(nameof(priceEp));

            var parameters = new Dictionary<string, object>()
            {
                { "symbol", symbol },
                { "clOrdID",clOrdID },
                { "side", EnumConverter.GetString(side) },
                { "orderQty",orderQty }
             };

            #region OptinalParams
            parameters.AddOptionalParameter("priceEp", priceEp);
            parameters.AddOptionalParameter("ordType", EnumConverter.GetString(ordType));
            parameters.AddOptionalParameter("stopPxEp", stopPxEp);
            parameters.AddOptionalParameter("timeInForce", EnumConverter.GetString(timeInForce));
            parameters.AddOptionalParameter("reduceOnly", reduceOnly);
            parameters.AddOptionalParameter("closeOnTrigger", closeOnTrigger);
            parameters.AddOptionalParameter("triggerType", EnumConverter.GetString(triggerType));
            parameters.AddOptionalParameter("takeProfitEp", takeProfitEp);
            parameters.AddOptionalParameter("stopLossEp", stopLossEp);
            parameters.AddOptionalParameter("slTrigger", EnumConverter.GetString(slTrigger));
            parameters.AddOptionalParameter("tpTrigger", EnumConverter.GetString(tpTrigger));
            parameters.AddOptionalParameter("pegOffsetValueEp", pegOffsetValueEp);
            parameters.AddOptionalParameter("pegPriceType", EnumConverter.GetString(pegPriceType));

            #endregion OptinalParams

           return await _baseClient.SendDataRequestAsync<PhemexCoinMOrder>("/orders/create", HttpMethod.Put, cancellationToken, parameters, signed: true).ConfigureAwait(false);
        }
    }
}
