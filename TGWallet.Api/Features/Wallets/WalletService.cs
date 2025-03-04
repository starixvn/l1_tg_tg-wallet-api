using MongoDB.Driver;
using Microsoft.Extensions.Options;
using TGWallet.API.Shared.Configuration;
using TGWallet.API.Shared.MongoDB;
using TGWallet.API.Features.Wallets.Models;
using Sentry;
using TGWallet.API.Features.Wallets.Databases;

namespace TGWallet.API.Features.Wallets
{
    public class WalletService : IWalletService
    {
        private readonly IMongoCollection<Wallet> _playerWallets;
        private readonly IHub _sentryHub;

        public WalletService(
            IMongoDbFactory mongoDbFactory,
            IOptions<MongoDbSettings> mongoDbSettings,
            IHub sentryHub)
        {
            _playerWallets = mongoDbFactory.GetCollection<Wallet>(
                mongoDbSettings.Value.WalletsCollectionName);
            _sentryHub = sentryHub;
        }

        public async Task<decimal> GetPlayerBalanceAsync(string playerId)
        {
            try
            {
                return 1000;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
} 