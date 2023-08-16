using BrasilConcursos.Domain.Entities;

namespace BrasilConcursos.Domain.Interfaces
{
    public interface IConcourseRepository
    {
        public Task<IEnumerable<Concourse>> GetConcoursesAsync();
        public Task<Concourse> GetConcourseByIdAsync(Guid id);
        public Task<Concourse> CreateAsync(Concourse concourse);
        public Task<Concourse> UpdateAsync(Concourse concourse);
        public Task DeleteAsync(Concourse concourse);
    }
}
