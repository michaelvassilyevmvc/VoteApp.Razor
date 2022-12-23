namespace Contracts
{
    public interface IRepositoryManager
    {
        IPoliticCandidateRepository PoliticCandidate { get; }
        IProductCandidateRepository ProductCandidate { get; }
        IVoteRepository Vote { get; }
        IUserRepository User { get; }
        void Save();
    }
}
