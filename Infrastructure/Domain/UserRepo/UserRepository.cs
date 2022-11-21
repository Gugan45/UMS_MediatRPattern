using Domain.Users;
using Infrastructure.Context;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Domain.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly IUMSContext _context;

        public UserRepository(IUMSContext context)
        {
            //   _settings = settings.Value;
            // var client = new MongoClient(_settings.ConnectionString);
            // var database = client.GetDatabase(_settings.DatabaseName);
            // _collection = database.GetCollection<User>(_settings.CollectionName);
            _context = context;
        }

        public void Create(User entity)
        {
            try
            {
                _context.Users.InsertOne(entity);
            }
            catch (MongoWriteConcernException ex)
            {
                throw ex;
            }
        }

        public bool Update(string postId, string id, User entity){
            return true;
        }

        public bool Delete(string postId, string id){
            return true;
        }

        public User GetUser(string id)
        {
            //  return _collection.Find(u => u.Id == id && u.IsActive).FirstOrDefault();
             return new User();
        }
        
        public IEnumerable<User> GetUser()
        {
            //   return _collection.Find(u => u.IsActive).SortBy(u => u.FirstName).ToList();
             return new List<User>();
        }
    }
}