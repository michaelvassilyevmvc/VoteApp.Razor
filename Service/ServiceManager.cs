using Contracts;

namespace Service.Contracts
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IVoteService> _voteService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IProductCandidateService> _productCandidateService;
        private readonly Lazy<IPoliticCandidateService> _politicCandidateService;
        public ServiceManager(IRepositoryManager repository, ILoggerManager logger)
        {
            _voteService = new Lazy<IVoteService>(() => new VoteService(repository, logger));
            _userService = new Lazy<IUserService>(() => new UserService(repository, logger));
            _politicCandidateService = new Lazy<IPoliticCandidateService>(() => new PoliticCandidateService(repository, logger));
            _productCandidateService = new Lazy<IProductCandidateService>(() => new ProductCandidateService(repository, logger));
        }
        public IVoteService VoteService => _voteService.Value;

        public IUserService UserService => _userService.Value;

        public IProductCandidateService ProductCandidateService => _productCandidateService.Value;

        public IPoliticCandidateService PoliticCandidateService => _politicCandidateService.Value;
    }
}
