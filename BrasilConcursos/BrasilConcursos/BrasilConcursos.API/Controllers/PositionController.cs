using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrasilConcursos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionController : Controller
    {
        private readonly IPositionService _service;
        public PositionController(IPositionService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Create(PositionDTO positionDTO)
        {
            await _service.AddAsync(positionDTO);
            return StatusCode(201, positionDTO);
        }
    }
}
