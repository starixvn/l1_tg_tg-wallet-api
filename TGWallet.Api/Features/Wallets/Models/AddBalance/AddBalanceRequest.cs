namespace TGWallet.API.Features.Wallets.Models.AddBalance
{
    public class AddBalanceRequest : BaseRequest
    {
        public decimal Amount { get; set; }
        public Dictionary<string, object> MetaData { get; set; } = new();
    }
}
