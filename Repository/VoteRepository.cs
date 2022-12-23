using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class VoteRepository : RepositoryBase<Vote>, IVoteRepository
    {
        public VoteRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
