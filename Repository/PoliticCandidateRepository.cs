using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class PoliticCandidateRepository : RepositoryBase<PoliticCandidate>, IPoliticCandidateRepository
    {
        public PoliticCandidateRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<PoliticCandidate> GetAllPoliticCandidates(bool trackChanges) => FindAll(trackChanges).OrderBy(x => x.PartyName).ToList();

        public PoliticCandidate GetPoliticCandidate(Guid candidateId, bool trackChanges) => FindByCondition(x => x.Id.Equals(candidateId), trackChanges).SingleOrDefault();
    }
}
