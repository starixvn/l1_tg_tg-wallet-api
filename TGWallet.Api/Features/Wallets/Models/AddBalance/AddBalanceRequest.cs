using System.ComponentModel.DataAnnotations;

namespace TGWallet.API.Features.Wallets.Models.AddBalance
{
    public class AddBalanceRequest : BaseRequest
    {
        [Required]
        public decimal Amount { get; set; }
        public Dictionary<string, object> MetaData { get; set; } = new();
    }
}
