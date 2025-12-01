using CatalogWebApi.DTO;
using CatalogWebApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CatalogWebApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EndowmentTypeController : ControllerBase
    {
        private readonly IEndowmentTypeService _endowmentTypeService;

        public EndowmentTypeController(IEndowmentTypeService endowmentTypeService)
        {
            _endowmentTypeService = endowmentTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EndowmentTypeDTO>>> GetAll()
        {
            var endowments = await _endowmentTypeService.GetAllEndowmentsTypesAsync();
            return Ok(endowments);
        }
    }
}
