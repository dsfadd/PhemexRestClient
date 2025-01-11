using CryptoExchange.Net.CommonObjects;
using CryptoExchange.Net.Objects;
using PhemexRestClient.Enums;
using PhemexRestClient.Models;

namespace PhemexClient.Interfaces.CoinMInterfaces
{
    public interface IPhemexRestClientCoinMApiTrading
    {
        public Task<WebCallResult<PhemexCoinMOrder>> PlaceOrderAsync(
            string symbol,
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
        CancellationToken cancellationToken = default
            );

        public Task<WebCallResult<IEnumerable<PhemexCoinMOrderByID>>> GetUserOrderByID(string symbol,
            string? orderID=null,
            string? clOrdID=null,
            CancellationToken cancellationToken=default);
    }
}