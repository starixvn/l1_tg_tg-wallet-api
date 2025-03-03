using MediatR;
using TGWallet.API.Features.Wallets.Models.AddBalance;

namespace TGWallet.API.Features.Wallets.Commands
{
    public class AddBallanceCommand : IRequest<AddBalanceResponse>
    {
        public AddBalanceRequest Request { get; }

        public AddBallanceCommand(AddBalanceRequest request)
        {
            Request = request;
        }
    }
}