using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexRestClient.Models
{
 

    public class PhemexUSDTMAccountAndPositions
    {
        public USDTMAccount account { get; set; }
        public USDTMPosition[] positions { get; set; }
    }

    public class USDTMAccount
    {
        public decimal accountBalanceRv { get; set; }
        public long accountId { get; set; }
        public decimal bonusBalanceRv { get; set; }
        public string currency { get; set; }
        public decimal totalUsedBalanceRv { get; set; }
        public long userID { get; set; }
    }

    public class USDTMPosition
    {
        public long accountID { get; set; }
        public decimal assignedPosBalanceRv { get; set; }
        public decimal avgEntryPrice { get; set; }
        public decimal avgEntryPriceRp { get; set; }
        public decimal bankruptCommRv { get; set; }
        public decimal bankruptPriceRp { get; set; }
        public decimal buyValueToCostRr { get; set; }
        public decimal cumClosedPnlRv { get; set; }
        public decimal cumFundingFeeRv { get; set; }
        public decimal cumTransactFeeRv { get; set; }
        public decimal curTermRealisedPnlRv { get; set; }
        public string currency { get; set; }
        public decimal deleveragePercentileRr { get; set; }
        public decimal estimatedOrdLossRv { get; set; }
        public string initMarginReqRr { get; set; }
        public long lastFundingTimeNs { get; set; }
        public long lastTermEndTimeNs { get; set; }
        public string leverageRr { get; set; }
        public decimal liquidationPriceRp { get; set; }
        public decimal maintMarginReqRr { get; set; }
        public decimal makerFeeRateRr { get; set; }
        public decimal markPriceRp { get; set; }
        public decimal posCostRv { get; set; }
        public string posMode { get; set; }
        public string posSide { get; set; }
        public decimal positionMarginRv { get; set; }
        public string positionStatus { get; set; }
        public decimal riskLimitRv { get; set; }
        public decimal sellValueToCostRr { get; set; }
        public string side { get; set; }
        public string size { get; set; }
        public string symbol { get; set; }
        public decimal takerFeeRateRr { get; set; }
        public string term { get; set; }
        public long transactTimeNs { get; set; }
        public decimal usedBalanceRv { get; set; }
        public long userID { get; set; }
        public decimal valueRv { get; set; }
    }

}
