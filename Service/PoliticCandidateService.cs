using Contracts;

namespace Service.Contracts
{
    public class PoliticCandidateService : IPoliticCandidateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public PoliticCandidateService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
