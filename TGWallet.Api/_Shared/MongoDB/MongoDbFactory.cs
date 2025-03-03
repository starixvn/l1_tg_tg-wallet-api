using MongoDB.Driver;
using Microsoft.Extensions.Options;
using TGWallet.API.Shared.Configuration;

namespace TGWallet.API.Shared.MongoDB
{
    public interface IMongoDbFactory
    {
        IMongoDatabase GetDatabase();
        IMongoCollection<T> GetCollection<T>(string collectionName);
    }

    public class MongoDbFactory : IMongoDbFactory
    {
        private readonly IMongoDatabase _database;

        public MongoDbFactory(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoDatabase GetDatabase() => _database;

        public IMongoCollection<T> GetCollection<T>(string collectionName)
            => _database.GetCollection<T>(collectionName);
    }
} 