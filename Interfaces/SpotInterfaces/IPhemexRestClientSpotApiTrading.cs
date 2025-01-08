using CryptoExchange.Net.Objects;
using PhemexClient.Enums;
using PhemexClient.Models;

namespace PhemexClient.Interfaces.SpotInterfaces
{
    public interface IPhemexRestClientSpotApiTrading
    {
        public Task<WebCallResult<PhemexSpotOrder>> PlaceOrderAsync(string symbol,
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
            CancellationToken cancellationToken = default);

        public Task<WebCallResult<PhemexSpotOrder>> GetAllOpenOrdersAsync(string symbol, CancellationToken cancellationToken = default);

        public Task<WebCallResult<PhemexSpotOrderMini>> GetOrderAsync(string symbol, string? orderID = null, string? clOrdID = null, CancellationToken cancellationToken = default);
    }
}