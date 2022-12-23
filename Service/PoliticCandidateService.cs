using AutoMapper;
using Contracts;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public class PoliticCandidateService : IPoliticCandidateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PoliticCandidateService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<PoliticCandidateDto> GetAllPoliticCandidate(bool trackChanges)
        {
            try
            {
                var politics = _repository.PoliticCandidate.GetAllPoliticCandidates(trackChanges);
                var politicsDto = _mapper.Map<IEnumerable<PoliticCandidateDto>>(politics);
                return politicsDto;
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllPoliticCandidate)} service method {ex}");
                throw;
            }
        }
    }
}
