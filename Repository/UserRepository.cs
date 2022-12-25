using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges) => FindAll(trackChanges).OrderBy(x => x.LName).ToList();

        public User GetUser(Guid userId, bool trackChanges) => FindByCondition(x => x.Id.Equals(userId), trackChanges).SingleOrDefault();
    }
}
