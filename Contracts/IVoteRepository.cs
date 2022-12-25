using Entities.Models;

namespace Contracts
{
    public interface IVoteRepository
    {
        IEnumerable<Vote> GetAllVotes(bool trackChanges);
        Vote GetVote(Guid userId, Guid candidateId, bool trackChanges);
    }
}
