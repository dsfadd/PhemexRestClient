using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Models
{

  

    public class PhemexAccountAndPositions
    {
        public Account account { get; set; }
        public Position[] positions { get; set; }
    }

    public class Account
    {
        public long accountId { get; set; }
        public string currency { get; set; }
        public long accountBalanceEv { get; set; }
        public long totalUsedBalanceEv { get; set; }
    }

    public class Position
    {
        public long accountID { get; set; }
        public string symbol { get; set; }
        public string currency { get; set; }
        public string side { get; set; }
        public string positionStatus { get; set; }
        public bool crossMargin { get; set; }
        public long leverageEr { get; set; }
        public long leverage { get; set; }
        public long initMarginReqEr { get; set; }
        public float initMarginReq { get; set; }
        public long maintMarginReqEr { get; set; }
        public float maintMarginReq { get; set; }
        public long riskLimitEv { get; set; }
        public long riskLimit { get; set; }
        public long size { get; set; }
        public long value { get; set; }
        public long valueEv { get; set; }
        public long avgEntryPriceEp { get; set; }
        public long avgEntryPrice { get; set; }
        public long posCostEv { get; set; }
        public long posCost { get; set; }
        public long assignedPosBalanceEv { get; set; }
        public long assignedPosBalance { get; set; }
        public long bankruptCommEv { get; set; }
        public long bankruptComm { get; set; }
        public long bankruptPriceEp { get; set; }
        public long bankruptPrice { get; set; }
        public long positionMarginEv { get; set; }
        public long positionMargin { get; set; }
        public long liquidationPriceEp { get; set; }
        public long liquidationPrice { get; set; }
        public long deleveragePercentileEr { get; set; }
        public long deleveragePercentile { get; set; }
        public long buyValueToCostEr { get; set; }
        public float buyValueToCost { get; set; }
        public long sellValueToCostEr { get; set; }
        public float sellValueToCost { get; set; }
        public long markPriceEp { get; set; }
        public float markPrice { get; set; }
        public long markValueEv { get; set; }
        public object markValue { get; set; }
        public long estimatedOrdLossEv { get; set; }
        public long estimatedOrdLoss { get; set; }
        public long usedBalanceEv { get; set; }
        public long usedBalance { get; set; }
        public long takeProfitEp { get; set; }
        public object takeProfit { get; set; }
        public long stopLossEp { get; set; }
        public object stopLoss { get; set; }
        public long realisedPnlEv { get; set; }
        public object realisedPnl { get; set; }
        public long cumRealisedPnlEv { get; set; }
        public object cumRealisedPnl { get; set; }
    }

}
