using Domain.Repositories;
using Domain.Users;

namespace Infrastructure.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        public IUserRepository UsersRepository { get; }
        public UnitofWork(IUserRepository userRepository)
        {
            UsersRepository = userRepository;
        }
    }
}