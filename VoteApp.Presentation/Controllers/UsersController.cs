﻿using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace VoteApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UsersController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            
                var users = _service.UserService.GetAllUsers(false);
                return Ok(users);
            
        }
    }
}
