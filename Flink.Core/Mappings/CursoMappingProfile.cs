using AutoMapper;
using Flink.Application.Requests;
using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
