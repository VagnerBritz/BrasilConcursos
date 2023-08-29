using AutoMapper;
using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Domain.Entities;

namespace BrasilConcursos.Application.Mappings
{
    public class DomainToDtoProfile : Profile
    {
        public DomainToDtoProfile()
        {
            CreateMap<Concourse, ConcourseDto>().ReverseMap();
            CreateMap<Position, PositionDto>().ReverseMap();
        }
    }
}
