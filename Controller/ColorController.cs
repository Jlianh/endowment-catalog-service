using CatalogWebApi.DTO;
using CatalogWebApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CatalogWebApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorController : ControllerBase
    {
        private readonly IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColorsDTO>>> GetAll()
        {
            var results = await _colorService.GetAllColorssAsync();
            return Ok(results);
        }
    }
}
