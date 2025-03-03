using MediatR;
using TGWallet.API.Features.Wallets.Models.AddBalance;

namespace TGWallet.API.Features.Wallets.Commands
{
    public class DeductBalanceCommand : IRequest<DeductBalanceResponse>
    {
        public DeductBalanceRequest Request { get; }

        public DeductBalanceCommand(DeductBalanceRequest request)
        {
            Request = request;
        }
    }
}