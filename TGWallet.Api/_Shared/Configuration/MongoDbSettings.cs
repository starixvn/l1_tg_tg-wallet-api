namespace TGWallet.API.Shared.Configuration
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string WalletsCollectionName { get; set; }
        public string WalletsTransactionsCollectionName { get; set; }
    }
} 