using BrasilConcursos.Domain.Entities;

namespace BrasilConcursos.Domain.Interfaces
{
    public interface IConcourseRepository
    {
        public Task<IEnumerable<Concourse>> GetPublicTendersAsync();
        public Task<Concourse> GetPublicTenderByIdAsync(int id);
        public Task<Concourse> CreateAsync(Concourse concourse);
        public Task<Concourse> UpdateAsync(Concourse concourse);
        public Task<Concourse> DeleteAsync(Concourse concourse);
    }
}
