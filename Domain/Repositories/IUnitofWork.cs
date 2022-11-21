using Domain.Users;

namespace Domain.Repositories
{
    public interface IUnitofWork
    {
        IUserRepository UsersRepository { get; }
        
    }
}