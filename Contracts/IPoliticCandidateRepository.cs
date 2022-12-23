using Entities.Models;

namespace Contracts
{
    public interface IPoliticCandidateRepository
    {
        IEnumerable<PoliticCandidate> GetAllPoliticCandidates(bool trackChanges);
    }
}
