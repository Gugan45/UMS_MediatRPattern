using MongoDB.Driver;
using Microsoft.Extensions.Options;
using Domain.Users;


namespace Infrastructure.Context
{
    public interface IUMSContext
    {
        IMongoCollection<User> Users { get; }
    }
}