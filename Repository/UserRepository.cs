using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(x => x.LName).ToList();
        }
    }
}
