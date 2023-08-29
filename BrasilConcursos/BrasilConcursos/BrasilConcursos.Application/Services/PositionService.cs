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

        public async Task<PositionDto> AddAsync(PositionDto positionDto)
        {
            var position = _mapper.Map<Position>(positionDto);
            await _repository.CreateAsync(position);
            return positionDto; // isso tá errado. Arrumar depois
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PositionDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PositionDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PositionDto positionDto)
        {
            throw new NotImplementedException();
        }
    }
}
