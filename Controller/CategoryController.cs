using CatalogWebApi.DTO;
using CatalogWebApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CatalogWebApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetAll()
        {
            var results = await _categoryService.GetAllCategoriesAsync();
            return Ok(results);
        }
    }
}
