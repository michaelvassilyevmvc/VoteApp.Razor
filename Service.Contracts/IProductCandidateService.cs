using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IProductCandidateService
    {
        IEnumerable<ProductCandidateDto> GetAllProductCandidate(bool trackChanges);
        ProductCandidateDto GetProductCandidate(Guid productCandidateId, bool trackChanges);
    }
}
