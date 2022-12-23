using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class PoliticCandidateRepository : RepositoryBase<PoliticCandidate>, IPoliticCandidateRepository
    {
        public PoliticCandidateRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<PoliticCandidate> GetAllPoliticCandidates(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(x => x.PartyName).ToList();
        }
    }
}
