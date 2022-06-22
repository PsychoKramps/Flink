using AutoMapper;
using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Infraestructure.Persistance;

namespace Flink.Application.Mappings
{
    public class LoginUserMappingProfile : Profile
    {
        public LoginUserMappingProfile()
        {
            CreateMap<PostUserLoginRequest, LoginUsuario>();
            CreateMap<LoginUsuario, PostUserLoginRequest>();

            CreateMap<UpdateLoginUserRequest, LoginUsuario>();
            CreateMap<LoginUsuario, UpdateLoginUserRequest>();

            CreateMap<LoginUsuario, LoginUsuarioResponse>();
        }
    }
}
