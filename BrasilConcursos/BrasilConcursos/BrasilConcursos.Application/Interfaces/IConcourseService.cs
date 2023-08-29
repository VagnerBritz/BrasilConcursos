using BrasilConcursos.Application.DTOs;

namespace BrasilConcursos.Application.Interfaces
{
    public interface IConcourseService
    {
        Task<IEnumerable<ConcourseDto>> GetAllAsync();
        Task<ConcourseDto> GetByIdAsync(Guid id);
        Task<ConcourseDto> AddAsync(ConcourseDto concourse);
        Task UpdateAsync(ConcourseDto concourse);
        Task DeleteAsync(Guid id);
    }
}
