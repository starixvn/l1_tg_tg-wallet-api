namespace TGWallet.API.Features.Wallets.Models.AddBalance
{
    public class DeductBalanceResponse : BaseResponse
    {
        public Guid TxId { get; set; }
        public decimal Balance { get; set; }
    }
}
