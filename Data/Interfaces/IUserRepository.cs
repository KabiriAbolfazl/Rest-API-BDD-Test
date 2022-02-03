using Entities.Models;

namespace Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id,CancellationToken cancellationToken);
        Task AddUser(User user, CancellationToken cancellationToken);
        Task DeleteUser(int id, CancellationToken cancellationToken);
        Task UpdateUser(int id, User user, CancellationToken cancellationToken);

    }
}
