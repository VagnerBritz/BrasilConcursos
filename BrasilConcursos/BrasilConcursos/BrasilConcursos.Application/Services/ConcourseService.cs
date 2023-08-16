using BrasilConcursos.Application.Interfaces;
using BrasilConcursos.Domain.Entities;
using BrasilConcursos.Domain.Interfaces;

namespace BrasilConcursos.Application.Services
{
    public class ConcourseService : IConcourseService
    {

        private readonly IConcourseRepository _concourseRepository;

        public ConcourseService(IConcourseRepository concourseRepository)
        {
            _concourseRepository = concourseRepository;
        }

        // posteriormente o retorno ser ConcourseDTO
        public async Task<IEnumerable<Concourse>> GetAllAsync()
        {
            var concourses = await _concourseRepository.GetConcoursesAsync();
            return concourses;
        }
        public async Task<Concourse> GetByIdAsync(Guid id)
        {
            var concourse =  await _concourseRepository.GetConcourseByIdAsync(id);
            return concourse;
        }
        public async Task<Concourse> AddAsync(Concourse newConcourse)
        {
           var concourse = await _concourseRepository.CreateAsync(newConcourse);
            return concourse;
        }
        public async Task<Concourse> UpdateAsync(Concourse concourse)
        {
            await _concourseRepository.UpdateAsync(concourse);
            return concourse;
        }
        public async Task DeleteAsync(Guid id)
        {
            var concourse = await _concourseRepository.GetConcourseByIdAsync(id);
            await _concourseRepository.DeleteAsync(concourse);            
        }
    }
}
