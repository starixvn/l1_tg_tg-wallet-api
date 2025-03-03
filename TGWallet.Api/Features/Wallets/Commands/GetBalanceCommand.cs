using MediatR;
using TGWallet.API.Features.Wallets.Models.Balance;

namespace TGWallet.API.Features.Wallets.Commands
{
    public class GetBalanceCommand : IRequest<PlayerBalanceResponse>
    {
        public PlayerBalanceRequest Request { get; }

        public GetBalanceCommand(PlayerBalanceRequest request)
        {
            Request = request;
        }
    }
}