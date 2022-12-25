using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IVoteService
    {
        IEnumerable<VoteDto> GetAllVotes(bool trackChanges);
        VoteDto GetVote(Guid userId, Guid candidateId, bool trackChanges);
    }
}
