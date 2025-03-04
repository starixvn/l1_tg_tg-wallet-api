using System.ComponentModel.DataAnnotations;

namespace TGWallet.API.Features.Wallets.Models.AddBalance
{
    public class DeductBalanceRequest : BaseRequest
    {
        [Required]
        public decimal Amount { get; set; }
        public Dictionary<string, object> MetaData { get; set; } = new();
    }
}
