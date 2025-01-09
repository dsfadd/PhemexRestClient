namespace PhemexClient.Models
{
    public class SpotWallet
    {
        public string currency { get; set; }
        public long balanceEv { get; set; }
        public long lockedTradingBalanceEv { get; set; }
        public long lockedWithdrawEv { get; set; }
        public long lastUpdateTimeNs { get; set; }
    }
}