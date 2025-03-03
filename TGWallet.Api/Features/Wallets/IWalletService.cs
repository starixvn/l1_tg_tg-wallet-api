using TGWallet.API.Features.Wallets.Models;

namespace TGWallet.API.Features.Wallets
{
    public interface IWalletService
    {
        Task<decimal> GetPlayerBalanceAsync(string playerId);
    }
} 