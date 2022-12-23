namespace Service.Contracts
{
    public interface IServiceManager
    {
        IVoteService VoteService { get; }
        IUserService UserService { get; }
        IProductCandidateService ProductCandidateService { get; }
        IPoliticCandidateService PoliticCandidateService { get; }
    }
}
