

namespace PhemexRestClient.Models
{
    public class PhemexUSDTMTicker
    {
        public decimal askRp { get; set; }
        public decimal bidRp { get; set; }
        public decimal fundingRateRr { get; set; }
        public decimal highRp { get; set; }
        public decimal indexRp { get; set; }
        public decimal lastRp { get; set; }
        public decimal lowRp { get; set; }
        public decimal markRp { get; set; }
        public decimal openInterestRv { get; set; }
        public decimal openRp { get; set; }
        public decimal predFundingRateRr { get; set; }
        public string symbol { get; set; }
        public long timestamp { get; set; }
        public decimal turnoverRv { get; set; }
        public decimal volumeRq { get; set; }
    }

}
