using Data.Context;
using Data.Interfaces;
using Entities.Models;

namespace Data.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task AddUser(User user, CancellationToken cancellationToken)
        {
            await _dbContext.Users.AddAsync(user, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteUser(int id, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.FindAsync(id, cancellationToken).ConfigureAwait(true);
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<User> GetUserById(int id, CancellationToken cancellationToken)
        {
            return await _dbContext.Users.FindAsync(id, cancellationToken);
        }

        public async Task UpdateUser(int id, User user, CancellationToken cancellationToken)
        {
            var updateUser = await _dbContext.Users.FindAsync(id, cancellationToken);
            updateUser.FirstName = user.FirstName;
            updateUser.SureName = user.SureName;
            updateUser.Email = user.Email;
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
