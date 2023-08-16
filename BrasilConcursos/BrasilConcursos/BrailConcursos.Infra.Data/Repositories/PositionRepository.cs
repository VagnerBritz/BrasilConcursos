using BrasilConcursos.Domain.Entities;
using BrasilConcursos.Domain.Interfaces;
using BrasilConcursos.Infra.Data.Context;

namespace BrasilConcursos.Infra.Data.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly ApplicationDbContext _context;

        public PositionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Position> CreateAsync(Position position)
        {
            _context.Add(position);
            await _context.SaveChangesAsync();
            return position;
        }

        public Task DeleteAsync(Position position)
        {
            throw new NotImplementedException();
        }

        public Task<Position> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Position position)
        {
            throw new NotImplementedException();
        }
    }
}
