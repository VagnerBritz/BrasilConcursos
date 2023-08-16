using BrasilConcursos.Application.Interfaces;
using BrasilConcursos.Domain.Entities;
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
        public async Task<ActionResult<IEnumerable<Concourse>>> Get()
        {
            var concourses = await _concourseService.GetAllAsync();
            if (concourses == null)
            {
                return NotFound();
            }
            return Ok(concourses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Concourse>> Get(Guid id)
        {
            var concourse = await _concourseService.GetByIdAsync(id);
            if (concourse == null) return NotFound("Invalid ID!");
            return Ok(concourse);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Concourse concourse)
        {
            await _concourseService.AddAsync(concourse);
            return StatusCode(201, concourse);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, Concourse concourseDTO)
        {
            if (id != concourseDTO.Id) return BadRequest("Id do concurso não corresponde ao informado");
            var entity = await _concourseService.GetByIdAsync(id);
            if (entity == null) return NotFound("Id not exist!");

            entity.RegistrationStartDate = concourseDTO.RegistrationStartDate;
            entity.RegistrationEndDate = concourseDTO.RegistrationEndDate;
            entity.NoticeUrl = concourseDTO.NoticeUrl;
            entity.PublicAgency = concourseDTO.PublicAgency;
            entity.ExaminationBoard = concourseDTO.ExaminationBoard;
            entity.UpdatedAt = DateTime.Now;
            await _concourseService.UpdateAsync(entity);
            return Ok(entity);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _concourseService.DeleteAsync(id);
            return NoContent();
        }
    }

}
