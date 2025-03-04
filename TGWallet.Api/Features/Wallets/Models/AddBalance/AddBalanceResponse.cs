namespace TGWallet.API.Features.Wallets.Models.AddBalance
{
    public class AddBalanceResponse : BaseResponse
    {
        public Guid TxId { get; set; }
        public decimal Balance { get; set; }
    }
}
