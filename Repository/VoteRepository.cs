using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class VoteRepository : RepositoryBase<Vote>, IVoteRepository
    {
        public VoteRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IEnumerable<Vote> GetAllVotes(bool trackChanges) => FindAll(trackChanges).OrderByDescending(x => x.VoteDate).ToList();

        public Vote GetVote(Guid userId, Guid candidateId, bool trackChanges) => FindByCondition(x => x.UserId.Equals(userId) && x.CandidateId.Equals(candidateId), trackChanges).SingleOrDefault();
    }
}
