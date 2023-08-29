using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrasilConcursos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionApiController : Controller
    {
        private readonly IPositionService _service;
        public PositionApiController(IPositionService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Create(PositionDto positionDto)
        {
            await _service.AddAsync(positionDto);
            return StatusCode(201, positionDto);
        }
    }
}
