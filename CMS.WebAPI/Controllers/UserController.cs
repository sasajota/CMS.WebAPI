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

        [HttpPut]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(_userService.Create(user));
        }

        [HttpDelete]
        public IActionResult Delete(User user)
        {
            return Ok(_userService.Delete(user));
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] User user)
        {
            return Ok(_userService.Edit(user));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Read(int id)
        {
            return Ok(_userService.Read(id));
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(_userService.List());
        }
    }
}