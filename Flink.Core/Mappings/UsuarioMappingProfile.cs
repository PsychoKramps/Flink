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
    public class UsuarioMappingProfile : Profile
    {

        public UsuarioMappingProfile()
        {
            CreateMap<GetUsuarioByIDRequest, Usuario>();
            CreateMap<Usuario, GetUsuarioByIDRequest>();

            CreateMap<CreateUsuarioRequest, Usuario>();
            CreateMap<Usuario, CreateUsuarioRequest>();

            CreateMap<UpdateUsuarioRequest, Usuario>();
            CreateMap<Usuario, UpdateUsuarioRequest>();


        }
    }
}
