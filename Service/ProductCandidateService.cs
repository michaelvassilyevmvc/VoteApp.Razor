using AutoMapper;
using Contracts;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public class ProductCandidateService : IProductCandidateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductCandidateService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ProductCandidateDto> GetAllProductCandidate(bool trackChanges)
        {
            
                var products = _repository.ProductCandidate.GetAllProductCandidate(trackChanges);
                var productsDto = _mapper.Map<IEnumerable<ProductCandidateDto>>(products);
                return productsDto;
           
        }
    }
}
