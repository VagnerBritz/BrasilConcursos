using BrasilConcursos.Application.DTOs;

namespace BrasilConcursos.Application.Interfaces
{
    public interface IConcourseService
    {
        Task<IEnumerable<ConcourseDTO>> GetAllAsync();
        Task<ConcourseDTO> GetByIdAsync(Guid id);
        Task<ConcourseDTO> AddAsync(ConcourseDTO concourse);
        Task UpdateAsync(ConcourseDTO concourse);
        Task DeleteAsync(Guid id);
    }
}
