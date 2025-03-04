using MediatR;
using MongoDB.Driver;
using TGWallet.API.Features.Wallets.Commands;
using TGWallet.API.Features.Wallets.Models;
using TGWallet.API.Shared.MongoDB;
using Microsoft.Extensions.Options;
using TGWallet.API.Shared.Configuration;
using Sentry;
using TGWallet.API.Features.Wallets.Models.AddBalance;
using TGWallet.API.Features.Wallets.Databases;

namespace TGWallet.API.Features.Wallets.Handlers
{
    public class AddBalanceCommandHandler : IRequestHandler<AddBallanceCommand, AddBalanceResponse>
    {
        private readonly IMongoCollection<Wallet> _playerWallet;
        private readonly IMongoCollection<WalletTransaction> _walletTransaction;
        private readonly IHub _sentryHub;

        public AddBalanceCommandHandler(
            IMongoDbFactory mongoDbFactory,
            IOptions<MongoDbSettings> mongoDbSettings,
            IHub sentryHub)
        {
            _playerWallet = mongoDbFactory.GetCollection<Wallet>(
                mongoDbSettings.Value.WalletsCollectionName);
            _walletTransaction = mongoDbFactory.GetCollection<WalletTransaction>(
                mongoDbSettings.Value.WalletsTransactionsCollectionName);
            _sentryHub = sentryHub;
        }

        public Task<AddBalanceResponse> Handle(AddBallanceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
} 