using CMS.Domain;
using CMS.Domain.Services.MenuItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemController : ControllerBase
    {

        private readonly ILogger<MenuItemController> _logger;
        private readonly IMenuItemService _menuItemService;
        public MenuItemController(ILogger<MenuItemController> logger,
                                    IMenuItemService menuItemService)
        {
            _logger = logger;
            _menuItemService = menuItemService;
        }


        [HttpPut]
        public IActionResult Create([FromBody] MenuItem menuItem)
        {
            return Ok(_menuItemService.Create(menuItem));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] MenuItem menuItem)
        {
            return Ok(_menuItemService.Delete(menuItem));
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] MenuItem menuItem)
        {
            return Ok(_menuItemService.Edit(menuItem));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Read(int id)
        {
            return Ok(_menuItemService.Read(id));
        }

        [HttpGet]
        public IActionResult List([FromBody] MenuItem menuItem)
        {
            return Ok(_menuItemService.List(menuItem));
        }
    }
}