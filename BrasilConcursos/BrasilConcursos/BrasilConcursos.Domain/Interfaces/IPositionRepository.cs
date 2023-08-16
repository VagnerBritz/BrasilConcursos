using BrasilConcursos.Domain.Entities;

namespace BrasilConcursos.Domain.Interfaces
{
    public interface IPositionRepository
    {
        public Task<Position> GetByIdAsync(Guid id);
        public Task<Position> CreateAsync(Position position);
        public Task UpdateAsync(Position position);
        public Task DeleteAsync(Position position);
    }
}
