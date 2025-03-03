using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TGWallet.API.Features.Wallets.Databases
{
    public class Wallet
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required string Id { get; set; }
        public required string PlayerId { get; set; }
        public required decimal Balance { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdated { get; set; }
    }
} 