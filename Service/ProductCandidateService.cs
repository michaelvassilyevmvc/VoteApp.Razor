using Contracts;

namespace Service.Contracts
{
    public class ProductCandidateService : IProductCandidateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ProductCandidateService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

    }
}
