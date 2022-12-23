using AutoMapper;
using Contracts;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<UserDto> GetAllUsers(bool trackChanges)
        {
            try
            {
                var users = _repository.User.GetAllUsers(trackChanges);
                var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
                return usersDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong with {nameof(GetAllUsers)} service method {ex}");
                throw;
            }


        }
    }
}
