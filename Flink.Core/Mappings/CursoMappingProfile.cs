using AutoMapper;
using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Infraestructure.Persistance;

namespace Flink.Application.Mappings
{
    public class CursoMappingProfile : Profile
    {
        public CursoMappingProfile()
        {
            CreateMap<PostCursoRequest, Curso>();
            CreateMap<Curso, PostCursoRequest>();

            CreateMap<PutCursoRequest, Curso>();
            CreateMap<Curso, PutCursoRequest>();

            CreateMap<Curso, CursoResponse>();

        }
    }
}
