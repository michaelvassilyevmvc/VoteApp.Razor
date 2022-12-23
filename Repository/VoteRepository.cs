using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class VoteRepository : RepositoryBase<Vote>, IVoteRepository
    {
        public VoteRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IEnumerable<Vote> GetAllVotes(bool trackChanges)
        {
            return FindAll(trackChanges).OrderByDescending(x=>x.VoteDate).ToList();
        }
    }
}
