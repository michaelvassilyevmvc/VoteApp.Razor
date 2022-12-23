using Entities.Models;

namespace Contracts
{
    public interface IProductCandidateRepository
    {
        IEnumerable<ProductCandidate> GetAllProductCandidate(bool trackChanges);
    }
}
