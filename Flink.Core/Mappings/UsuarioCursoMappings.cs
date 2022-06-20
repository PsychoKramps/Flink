using AutoMapper;
using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Mappings
{
    public class UsuarioCursoMappings : Profile
    {
        public UsuarioCursoMappings()
        {
            CreateMap<GetByIdUsuarioCursoRequest, UsuarioCurso>();
            CreateMap<UsuarioCurso, GetByIdUsuarioCursoRequest>();

            CreateMap<PostUsuarioCursoRequest, UsuarioCurso>();
            CreateMap<UsuarioCurso, PostUsuarioCursoRequest>();

            CreateMap<UpdateUsuarioCursoRequest, UsuarioCurso>();
            CreateMap<UsuarioCurso, UpdateUsuarioCursoRequest>();

            CreateMap<UsuarioCurso, UsuarioCursoResponse>();

        }
    }
}
