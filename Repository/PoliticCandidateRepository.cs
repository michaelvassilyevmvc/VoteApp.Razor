using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class PoliticCandidateRepository : RepositoryBase<PoliticCandidate>, IPoliticCandidateRepository
    {
        public PoliticCandidateRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
