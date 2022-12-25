using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IPoliticCandidateService
    {
        IEnumerable<PoliticCandidateDto> GetAllPoliticCandidate(bool trackChanges);
        PoliticCandidateDto GetPoliticCandidate(Guid politicCandidateId, bool trackChanges);
    }
}
