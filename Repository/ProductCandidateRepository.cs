using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class ProductCandidateRepository : RepositoryBase<ProductCandidate>, IProductCandidateRepository
    {
        public ProductCandidateRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
