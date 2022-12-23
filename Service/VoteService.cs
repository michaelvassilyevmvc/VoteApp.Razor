using AutoMapper;
using Contracts;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public class VoteService : IVoteService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public VoteService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<VoteDto> GetAllVotes(bool trackChanges)
        {
            try
            {
                var votes = _repository.Vote.GetAllVotes(trackChanges);
                var votesDto = _mapper.Map<IEnumerable<VoteDto>>(votes);    
                return votesDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong with {nameof(GetAllVotes)} service method {ex}");
                throw;
            }
        }
    }
}
