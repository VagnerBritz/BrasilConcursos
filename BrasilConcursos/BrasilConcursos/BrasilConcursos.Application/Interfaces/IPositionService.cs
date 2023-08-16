using BrasilConcursos.Application.DTOs;

namespace BrasilConcursos.Application.Interfaces
{
    public interface IPositionService
    {
        Task<IEnumerable<PositionDTO>> GetAllAsync();
        Task<PositionDTO> GetByIdAsync(Guid id);
        Task<PositionDTO> AddAsync(PositionDTO positionDTO);
        Task UpdateAsync(PositionDTO positionDTO);
        Task DeleteAsync(Guid id);
    }
}
