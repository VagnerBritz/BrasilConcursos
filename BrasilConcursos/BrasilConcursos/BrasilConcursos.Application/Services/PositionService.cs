using AutoMapper;
using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Application.Interfaces;
using BrasilConcursos.Domain.Entities;
using BrasilConcursos.Domain.Interfaces;

namespace BrasilConcursos.Application.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _repository;
        private readonly IMapper _mapper;
        public PositionService(IPositionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PositionDTO> AddAsync(PositionDTO positionDTO)
        {
            var position = _mapper.Map<Position>(positionDTO);
            await _repository.CreateAsync(position);
            return positionDTO; // isso tá errado. Arrumar depois
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PositionDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PositionDTO> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PositionDTO positionDTO)
        {
            throw new NotImplementedException();
        }
    }
}
