using BrasilConcursos.Domain.Entities;

namespace BrasilConcursos.Application.Interfaces
{
    public interface IConcourseService
    {
        // posteriormente o retorno ser ConcourseDTO
        Task<IEnumerable<Concourse>> GetAllAsync();
        Task<Concourse> GetByIdAsync(Guid id);
        Task<Concourse> AddAsync(Concourse concourse);
        Task<Concourse> UpdateAsync(Concourse concourse);
        Task DeleteAsync(Guid id);
    }
}
