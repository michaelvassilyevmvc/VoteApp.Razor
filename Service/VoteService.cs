using Contracts;

namespace Service.Contracts
{
    public class VoteService : IVoteService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public VoteService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
