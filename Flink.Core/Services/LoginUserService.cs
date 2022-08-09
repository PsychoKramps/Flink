using AutoMapper;
using Flink.Application.Interfaces;
using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Domain.Interfaces;
using Flink.Infraestructure.Persistance;

namespace Flink.Application.Services
{
    public class LoginUserService : ILoginUsuarioService
    {
        private readonly IUserLoginRepository _repository;
        private readonly IMapper _mapper;

        public LoginUserService(IUserLoginRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<LoginUsuarioResponse> GetLoginUsuario()
        {
            var loginUser = _repository.GetLoginUsuario();
            var loginUserResponse = _mapper.Map<IEnumerable<LoginUsuarioResponse>>(loginUser);
            return loginUserResponse;
        }

        public LoginUsuarioResponse GetLoginUsuarioById(int id)
        {
            var loginUser = _repository.GetLoginUsuarioById(id);
            var loginUserResponse = _mapper.Map<LoginUsuarioResponse>(loginUser);
            return loginUserResponse;
        }

        public LoginUsuarioResponse GetLoginUsuariobyName(string name)
        {
            var loginUser = _repository.GetLoginUsuarioByName(name);
            var loginUserResponse = _mapper.Map<LoginUsuarioResponse>(loginUser);
            return loginUserResponse;
        }

        public void InsertLoginUsuario(PostUserLoginRequest loginUsuariopost)
        {
            var loginUsuario = _mapper.Map<LoginUsuario>(loginUsuariopost);
            _repository.InsertLoginUsuario(loginUsuario);
        }

    }
}
