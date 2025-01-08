using CryptoExchange.Net.Objects;
using CryptoExchange.Net;
using PhemexClient.Enums;
using PhemexClient.Models;
using PhemexClient.SpotApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoExchange.Net.Converters.JsonNet;
using PhemexClient.Interfaces.ContractInterfaces;

namespace PhemexClient.ContractApi
{
    public enum TrailingOrderPriceType
    {
        TrailingStopPeg, 
        TrailingTakeProfitPeg
    }

    internal class PhemexRestClientContractApiTrading: IPhemexRestClientContractApiTrading
    {
        private PhemexRestClientContractApi _baseClient;
        public PhemexRestClientContractApiTrading(PhemexRestClientContractApi baseClient)
        {
            _baseClient = baseClient;
        }
        public async Task<WebCallResult<PhemexContractOrder>> PlaceOrderAsync(string symbol,
            string clOrdID,
            OrderSide side,
            long orderQty,
            long? priceEp=null,
            OrderType? ordType=null,
            long? stopPxEp=null,
            TimeInForceType? timeInForce=null,
            bool? reduceOnly=null,
            bool? closeOnTrigger=null,
            TriggerType? triggerType = null,
            long? takeProfitEp=null,
            long? stopLossEp=null,
            TriggerType? slTrigger=null,
            TriggerType? tpTrigger=null,
            long? pegOffsetValueEp=null,
            TrailingOrderPriceType? pegPriceType=null,
            CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, object>()
    {
        { "symbol", symbol },
        { "clOrdID", clOrdID },
        { "side", EnumConverter.GetString(side) },
        { "orderQty", orderQty }
    };
            #region OptionalParams
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
            #endregion OptionalParams

            return await _baseClient.SendRequestAsync<PhemexContractOrder>("/orders/create",
                HttpMethod.Put, 
                cancellationToken, parameters, signed: true)
                .ConfigureAwait(false);
        }

        public async Task<WebCallResult<PhemexSpotOrder>> GetAllOpenOrdersAsync(string symbol, CancellationToken cancellationToken = default)
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
