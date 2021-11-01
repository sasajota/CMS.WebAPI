using CMS.Domain;
using CMS.Domain.Services.Files;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {

        private readonly ILogger<FileController> _logger;
        private readonly IFileService _fileService;

        public FileController(ILogger<FileController> logger,
                                IFileService fileService)
        {
            _logger = logger;
            _fileService = fileService;
        }

        [HttpPut]
        public IActionResult Create([FromBody] File file)
        {
            return Ok(_fileService.Create(file));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] File file)
        {
            return Ok(_fileService.Delete(file));
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] File file)
        {
            return Ok(_fileService.Edit(file));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Read(int id)
        {
            return Ok(_fileService.Read(id));
        }        
        
        [HttpGet]
        public IActionResult List([FromBody] File file)
        {
            return Ok(_fileService.List(file));
        }
    }
}