using System.ComponentModel.DataAnnotations;

namespace TGWallet.API.Features.Wallets.Models
{
    public class BaseResponse
    {
        [Required]
        public string StatusCode { get; set; }

        public string Message { get; set; }
    }
}
