using System.ComponentModel.DataAnnotations;

namespace TGWallet.API.Features.Wallets.Models.Balance
{
    public class PlayerBalanceRequest
    {
        [Required]
        public string PlayerId { get; set; }
    }
}