using AutoMapper;
using Flink.Application.Requests;
using Flink.Infraestructure.Persistance;

namespace Flink.Application.Mappings
{
    public class CursoMappingProfile : Profile
    {
        public CursoMappingProfile()
        {
            CreateMap<CursoRequest, Curso>();
            CreateMap<Curso, CursoRequest>();

        }
    }
}
