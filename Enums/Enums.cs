using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Enums
{
    public enum OrderType
    {
        Market,
        Limit,
        Stop,
        StopLimit,
        MarketIfTouched,
        LimitIfTouched,
        MarketAsLimit,
        StopAsLimit,
        MarketIfTouchedAsLimit
    }

    public enum OrderSide
    {
        Sell,
        Buy
    }
    public enum QuantityType
    {
        ByBase,
        ByQuote
    }
    public enum TriggerType
    {
        ByLastPrice,
        ByMarkPrice
    }
    public enum TimeInForceType
    {
        GoodTillCancel,
        PostOnly,
        ImmediateOrCancel,
        FillOrKill
    }
}
