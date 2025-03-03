namespace TGWallet.API.Features.Wallets.Models.Balance
{
    public class PlayerBalanceResponse : BaseResponse
    {
        public IEnumerable<PlayerWallet> PlayerWallets;
    }

    public class PlayerWallet
    {
        public decimal Balance { get; set; }

        public string Currency { get; set; }
    }
}