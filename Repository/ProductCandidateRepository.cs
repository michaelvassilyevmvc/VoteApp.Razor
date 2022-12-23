using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class ProductCandidateRepository : RepositoryBase<ProductCandidate>, IProductCandidateRepository
    {
        public ProductCandidateRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<ProductCandidate> GetAllProductCandidate(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(x=>x.Name).ToList();
        }
    }
}
