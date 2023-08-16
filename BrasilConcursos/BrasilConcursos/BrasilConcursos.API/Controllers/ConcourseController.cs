using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrasilConcursos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConcourseController : ControllerBase
    {
        private readonly IConcourseService _concourseService;
        public ConcourseController(IConcourseService concourseService)
        {
            _concourseService = concourseService;

        }

        [HttpGet("/surprise")]
        public string GetMessage() => "Welcome to my concourse API!!";
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConcourseDTO>>> Get()
        {
            var concoursesList = await _concourseService.GetAllAsync();
            if (concoursesList == null)
            {
                return NotFound();
            }
            return Ok(concoursesList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConcourseDTO>> Get(Guid id)
        {
            var concourse = await _concourseService.GetByIdAsync(id);
            if (concourse == null) return NotFound("Invalid ID!");
            return Ok(concourse);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ConcourseDTO concourse)
        {

            await _concourseService.AddAsync(concourse);
            return StatusCode(201, concourse);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, ConcourseDTO concourseDTO)
        {
            if (id != concourseDTO.Id) return BadRequest("Id do concurso não corresponde ao informado");
            var entity = await _concourseService.GetByIdAsync(id);
            if (entity == null) return NotFound("Id not exist!");
            await _concourseService.UpdateAsync(concourseDTO);
            return Ok(concourseDTO);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _concourseService.DeleteAsync(id);
            return NoContent();
        }
    }

}
