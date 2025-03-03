using MongoDB.Driver;
using Microsoft.Extensions.Options;
using TGWallet.API.Shared.Configuration;
using TGWallet.API.Shared.MongoDB;
using TGWallet.API.Features.Wallets.Models;
using Sentry;

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

        public async Task<Wallet> GetPlayerBalanceAsync(string operatorId, string playerId, string siteId)
        {
            try
            {
                return await _playerWallets.Find(x => 
                    x.PlayerId == playerId)
                .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                _sentryHub.CaptureException(ex, scope =>
                {
                    scope.SetExtra("operatorId", operatorId);
                    scope.SetExtra("playerId", playerId);
                    scope.SetExtra("siteId", siteId);
                });
                throw;
            }
        }
    }
} 