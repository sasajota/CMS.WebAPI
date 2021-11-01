using CMS.Domain;
using CMS.Domain.Services.Articles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {

        private readonly ILogger<ArticleController> _logger;
        private readonly IArticleService _articleService;

        public ArticleController(ILogger<ArticleController> logger,
                                IArticleService articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        [HttpPut]
        public IActionResult Create([FromBody] Article article)
        {
            return Ok(_articleService.Create(article));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Article article)
        {
            return Ok(_articleService.Delete(article));
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] Article article)
        {
            return Ok(_articleService.Edit(article));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Read([FromBody] Article article)
        {
            return Ok(_articleService.Read(article));
        }

        [HttpGet]
        public IActionResult List([FromBody] Article article)
        {
            return Ok(_articleService.List(article));
        }
    }
}