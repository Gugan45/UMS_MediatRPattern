using Domain.Users;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBConfiguration;

namespace Infrastructure.Context
{
    public class UMSContext : IUMSContext
    {
        private readonly IMongoDatabase db;

        public UMSContext(IOptions<UserDBSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            db = client.GetDatabase(options.Value.DatabaseName);
        }
        // public IMongoCollection<Post> Posts => db.GetCollection<Post>("Posts");
        public IMongoCollection<User> Users => throw new NotImplementedException();
    }
}