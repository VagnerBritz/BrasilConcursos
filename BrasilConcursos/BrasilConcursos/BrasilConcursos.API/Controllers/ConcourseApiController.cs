using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrasilConcursos.API.Controllers
{
    /// <summary>
    /// gfhgrhgrjhtjkhkj
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ConcourseApiController : ControllerBase
    {
        private readonly IConcourseService _concourseService;
        public ConcourseApiController(IConcourseService concourseService)
        {
            _concourseService = concourseService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConcourseDto>>> Get()
        {
            var concourseList = await _concourseService.GetAllAsync();

            return concourseList.Any() ? Ok(concourseList) : NotFound("There are no active public tenders.");

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConcourseDto>> Get(Guid id)
        {
            var concourse = await _concourseService.GetByIdAsync(id);
            if (concourse == null) return NotFound("Invalid ID!");
            return Ok(concourse);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ConcourseDto concourse)
        {
            if (ModelState.IsValid)
            {
                await _concourseService.AddAsync(concourse);
                return StatusCode(201, concourse);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, ConcourseDto concourseDto)
        {
            // if (id != concourseDTO.Id) return BadRequest("Concourse Id does not match.");

            try
            {
                await _concourseService.UpdateAsync(concourseDto);
            }
            catch (DbUpdateConcurrencyException e)
            {
                var existEntity = await _concourseService.GetByIdAsync(id);
                if (existEntity == null)
                {
                    return NotFound("Concourse not found.");
                }
                else
                {
                    return BadRequest(e.Message);
                }
            }
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _concourseService.DeleteAsync(id);
            return NoContent();
        }
    }
}


