using AutoMapper;
using BrasilConcursos.Application.DTOs;
using BrasilConcursos.Domain.Entities;

namespace BrasilConcursos.Application.Mappings
{
    public class DomainToDtoProfile : Profile
    {
        public DomainToDtoProfile()
        {
            CreateMap<Concourse, ConcourseDTO>().ReverseMap();
            CreateMap<Position, PositionDTO>().ReverseMap();
        }
    }
}
