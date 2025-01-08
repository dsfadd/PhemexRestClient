namespace PhemexClient.Models
{
    public class SpotWallet
    {
        public string currency { get; set; }
        public int balanceEv { get; set; }
        public int lockedTradingBalanceEv { get; set; }
        public int lockedWithdrawEv { get; set; }
        public int lastUpdateTimeNs { get; set; }
    }
}