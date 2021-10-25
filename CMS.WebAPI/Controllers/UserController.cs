using CMS.Domain;
using CMS.Domain.Services.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger,
                                IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return _userService.Get(id);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return _userService.Get();
        }


        [HttpPut]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(_userService.Create(user));
        }
    }
}
