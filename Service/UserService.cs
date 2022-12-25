﻿using AutoMapper;
using Contracts;
using Entities.Extensions;
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
                var users = _repository.User.GetAllUsers(trackChanges);
                var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
                return usersDto;
        }

        public UserDto GetUser(Guid userId, bool trackChanges)
        {
            var user = _repository.User.GetUser(userId, trackChanges);
            if (user == null)
            {
                throw new UserNotFoundException(userId);
            }

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
