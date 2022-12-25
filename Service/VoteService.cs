using AutoMapper;
using Contracts;
using Entities.Extensions;
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
           
                var votes = _repository.Vote.GetAllVotes(trackChanges);
                var votesDto = _mapper.Map<IEnumerable<VoteDto>>(votes);    
                return votesDto;
           
        }

        public VoteDto GetVote(Guid userId, Guid candidateId, bool trackChanges)
        {
            var vote = _repository.Vote.GetVote(userId, candidateId, trackChanges);
            if(vote == null)
            {
                throw new VoteNotFoundException(userId, candidateId);
            }

            var voteDto = _mapper.Map<VoteDto>(vote);
            return voteDto;
        }
    }
}
