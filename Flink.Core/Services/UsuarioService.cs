using AutoMapper;
using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Domain.Application;
using Flink.Domain.Interfaces;
using Flink.Infraestructure.Persistance;

namespace Flink.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void DeleteUsuario(DeleteUsuarioRequest request)
        {

            _repository.DeleteUsuario(request.IdUsuario);
        }

        public IEnumerable<UsuarioResponse> GetUsuarios()
        {
            var usuario = _repository.GetUsuarios();
            var usuarioResponse = _mapper.Map<IEnumerable<UsuarioResponse>>(usuario);
            return usuarioResponse;
            
        }

        public UsuarioResponse GetUsuariosById(int idUsuario)
        {
            var usuario = _repository.GetUsuariosById(idUsuario);
            var usuarioReponse = _mapper.Map<UsuarioResponse>(usuario);
            return usuarioReponse;
        }

        public void InsertUsuario(CreateUsuarioRequest usuario)
        {
            var usuariopost = _mapper.Map<Usuario>(usuario);
            _repository.InsertUsuario(usuariopost);
        }

        public void UpdateUsuario(UpdateUsuarioRequest usuario)
        {
            var usuarioput = _mapper.Map<Usuario>(usuario);
            _repository.UpdateUsuario(usuarioput);
        }
    }
}
