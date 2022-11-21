using Domain.Users;
using System.Collections.Generic;

namespace Domain.Users
{
    public interface IUserRepository
    {
        void Create(User entity);
        bool Update(string postId, string id, User entity);
        bool Delete(string postId, string id);
        User GetUser(string id);
        IEnumerable<User> GetUser();
    }
}