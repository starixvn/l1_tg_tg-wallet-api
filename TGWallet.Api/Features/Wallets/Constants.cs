namespace TGWallet.API.Features.Wallets
{
    public static class TransactionType
    {
        public const string AddBalance = "addBalance";
        public const string DeductBalance = "deductBalance";
        public const string Deposit = "deposit";
        public const string Withdraw = "withdraw";
    };
    
    public static class TransactionStatus
    {
        public const string Pending = "pending";
        public const string Completed = "completed";
        public const string Failed = "failed";
        public const string Cancelled = "cancelled";
        public const string Waiting = "waiting";
    }
}
