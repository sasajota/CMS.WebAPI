using CMS.Domain;
using CMS.Domain.Services.Menus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {

        private readonly ILogger<MenuController> _logger;
        private readonly IMenuService _menuService;

        public MenuController(ILogger<MenuController> logger,
                                IMenuService menuService)
        {
            _logger = logger;
            _menuService = menuService;
        }

        [HttpPut]
        public IActionResult Create([FromBody] Menu menu)
        {
            return Ok(_menuService.Create(menu));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Menu menu)
        {
            return Ok(_menuService.Delete(menu));
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] Menu menu)
        {
            return Ok(_menuService.Edit(menu));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Read([FromBody] Menu menu)
        {
            return Ok(_menuService.Read(menu));
        }

        [HttpGet]
        public IActionResult List([FromBody] Menu menu)
        {
            return Ok(_menuService.List(menu));
        }
    }
}