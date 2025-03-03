using System.ComponentModel.DataAnnotations;

namespace TGWallet.API.Features.Wallets.Models
{
    public class BaseRequest
    {
        [Required]
        public string Seq { get; set; }

        [Required]
        public string PlayerId { get; set; }
    }
}
