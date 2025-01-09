using CryptoExchange.Net.Objects;
using PhemexClient.ContractApi;
using PhemexClient.Enums;
using PhemexClient.Models;

namespace PhemexClient.Interfaces.ContractInterfaces
{
    public interface IPhemexRestClientContractApiTrading
    {
        public Task<WebCallResult<PhemexContractOrder>> PlaceOrderAsync(string symbol,
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
               CancellationToken cancellationToken = default);

     
    }
}
