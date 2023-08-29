using BrasilConcursos.Application.DTOs;

namespace BrasilConcursos.Application.Interfaces
{
    public interface IPositionService
    {
        Task<IEnumerable<PositionDto>> GetAllAsync();
        Task<PositionDto> GetByIdAsync(Guid id);
        Task<PositionDto> AddAsync(PositionDto positionDto);
        Task UpdateAsync(PositionDto positionDto);
        Task DeleteAsync(Guid id);
    }
}
