using AutoMapper;
using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Application.Interfaces;
using BrasilConcursos.Domain.Entities;
using BrasilConcursos.Domain.Interfaces;

namespace BrasilConcursos.Application.Services
{
    public class ConcourseService : IConcourseService
    {

        private readonly IConcourseRepository _concourseRepository;
        private readonly IMapper _mapper;
        public ConcourseService(IConcourseRepository concourseRepository, IMapper mapper)
        {
            _concourseRepository = concourseRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ConcourseDto>> GetAllAsync()
        {
            var concoursesList = await _concourseRepository.GetConcoursesAsync();
            return _mapper.Map<IEnumerable<ConcourseDto>>(concoursesList);
        }
        public async Task<ConcourseDto> GetByIdAsync(Guid id)
        {
            var concourse = await _concourseRepository.GetConcourseByIdAsync(id);
            return _mapper.Map<ConcourseDto>(concourse);
        }
        public async Task<ConcourseDto> AddAsync(ConcourseDto concourseDTO)
        {
            var concourseEntity = _mapper.Map<Concourse>(concourseDTO);
            concourseEntity.Id = Guid.NewGuid();
            var concourse = await _concourseRepository.CreateAsync(concourseEntity);
            return _mapper.Map<ConcourseDto>(concourse);
        }
        public async Task UpdateAsync(ConcourseDto concourseDTO)
        {

            var concourse = _mapper.Map<Concourse>(concourseDTO);
            await _concourseRepository.UpdateAsync(concourse);

        }
        public async Task DeleteAsync(Guid id)
        {
            var concourse = await _concourseRepository.GetConcourseByIdAsync(id);

            await _concourseRepository.DeleteAsync(concourse);
        }
    }
}
