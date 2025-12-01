using CatalogWebApi.DTO;
using CatalogWebApi.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CatalogWebApi.NewFolder
{

    [ApiController]
    [Route("api/[controller]")]
    public class EndowmentController : ControllerBase
    {
        private readonly IEndowmentService _endowmentService;

        public EndowmentController(IEndowmentService endowmentService)
        {
            _endowmentService = endowmentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EndowmentDTO>>> GetAll()
        {
            var endowments = await _endowmentService.GetAllEndowmentsAsync();
            return Ok(endowments);
        } 
        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<EndowmentDTO>> GetById(int id)
        {
            var endowment = await _endowmentService.GetEndowmentByIdAsync(id);
            if (endowment == null) return NotFound();
            return Ok(endowment);
        }
        [HttpGet("GetByEndowmentTypeId/{id}")]
        public async Task<ActionResult<IEnumerable<EndowmentDTO>>> GetByEndowmentTypeId(int id)
        {
            var endowment = await _endowmentService.GetEndowmentByEndowmentTypeIdAsync(id);
            if (endowment == null) return NotFound();
            return Ok(endowment);
        }

        [HttpPost("GetByFilters")]
        public async Task<ActionResult<IEnumerable<EndowmentDTO>>> GetEndowmentsByFilters(FiltersDTO filtersDTO)
        {
            var endowment = await _endowmentService.GetEndowmentsByFiltersAsync(filtersDTO);
            if (endowment == null) return NotFound();
            return Ok(endowment);
        }
        [HttpPost("GetByName")]
        public async Task<ActionResult<IEnumerable<EndowmentDTO>>> GetEndowmentsByName(NameSeachDTO nameSeachDTO)
        {
            var endowment = await _endowmentService.GetEndowmentByNameAsync(nameSeachDTO);
            if (endowment == null) return NotFound();
            return Ok(endowment);
        }

        [HttpPost]
        public async Task<ActionResult<EndowmentDTO>> Create([FromForm] SaveEndowmentDTO saveEndowmentDTO)
        {
            var endowment = await _endowmentService.CreateEndowmentAsync(saveEndowmentDTO);
            return CreatedAtAction(nameof(GetById), new {id = endowment.id}, endowment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EndowmentDTO>> Update(int id, SaveEndowmentDTO saveEndowmentDTO)
        {
            try
            {
                var endowment = await _endowmentService.UpdateEndowmentAsync(id, saveEndowmentDTO);
                return Ok(endowment);
            }
            catch (KeyNotFoundException ex) { 
                return NotFound(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _endowmentService.DeleteEndowmentAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex);
            }
        }
    }
}
