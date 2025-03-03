using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TGWallet.API.Features.Wallets.Databases
{
    public class WalletTransaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string TransactionId { get; set; }
        public long PlayerId { get; set; }
        public string OperatorId { get; set; }
        public string SiteId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public decimal BalanceBefore { get; set; }
        public decimal BalanceAfter { get; set; }
        public string Seq { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
    }
} 