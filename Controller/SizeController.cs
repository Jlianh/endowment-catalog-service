using CatalogWebApi.DTO;
using CatalogWebApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CatalogWebApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class SizeController : ControllerBase
    {
        private readonly ISizeService _sizeService;

        public SizeController(ISizeService sizeService)
        {
            _sizeService = sizeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SizesDTO>>> GetAll()
        {
            var results = await _sizeService.GetAllSizesAsync();
            return Ok(results);
        }
    }
}
