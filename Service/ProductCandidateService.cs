using AutoMapper;
using Contracts;
using Entities.Extensions;
using Shared.DataTransferObjects;
using Entities.Extensions;

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

        public ProductCandidateDto GetProductCandidate(Guid productCandidateId, bool trackChanges)
        {
            var product = _repository.ProductCandidate.GetProductCandidate(productCandidateId, trackChanges);
            if(product is null)
            {
                throw new ProductCandidateNotFoundException(productCandidateId);
            }

            var productDto = _mapper.Map<ProductCandidateDto>(product);
            return productDto;
        }
    }
}
