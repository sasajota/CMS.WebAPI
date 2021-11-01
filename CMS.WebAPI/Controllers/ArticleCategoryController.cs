using CMS.Domain;
using CMS.Domain.Services.ArticleCategories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleCategoryController : ControllerBase
    {

        private readonly ILogger<ArticleCategoryController> _logger;
        private readonly IArticleCategoryService _articleCategoryService;

        public ArticleCategoryController(ILogger<ArticleCategoryController> logger,
                                IArticleCategoryService articleCategoryService)
        {
            _logger = logger;
            _articleCategoryService = articleCategoryService;
        }

        [HttpPut]
        public IActionResult Create([FromBody] ArticleCategory articleCategory)
        {
            return Ok(_articleCategoryService.Create(articleCategory));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] ArticleCategory articleCategory)
        {
            return Ok(_articleCategoryService.Delete(articleCategory));
        }

        [HttpPatch]
        public IActionResult Edit([FromBody] ArticleCategory articleCategory)
        {
            return Ok(_articleCategoryService.Edit(articleCategory));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Read(int id)
        {
            return Ok(_articleCategoryService.Read(id));
        }

        [HttpGet]
        public IActionResult List([FromBody] ArticleCategory articleCategory)
        {
            return Ok(_articleCategoryService.List(articleCategory));
        }
    }
}