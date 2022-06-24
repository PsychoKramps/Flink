using AutoMapper;
using Flink.Application.Interfaces;
using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Domain.Interfaces;
using Flink.Infraestructure.Persistance;

namespace Flink.Application.Services
{
    public class UsuarioCursoService : ICursoUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioCursoRepository _repository;
        public UsuarioCursoService(IUsuarioCursoRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public void DeleteUsuarioCurso(DeleteUsuarioCursoRequest request)
        {
            _repository.DeleteUsuarioCurso(request.UsuarioCursoId);
        }

        public IEnumerable<UsuarioCursoResponse> GetUsuarioCursos()
        {
            var usuarioCurso = _repository.GetUsuarioCursos();
            var usuarioCursoResponse = _mapper.Map<IEnumerable<UsuarioCursoResponse>>(usuarioCurso);
            return usuarioCursoResponse;
        }

        public UsuarioCursoResponse GetUsuariosCursoById(int UsuarioCursoId)
        {
            var usuarioCurso = _repository.GetUsuariosCursoById(UsuarioCursoId);
            var usuarioCursoResponse = _mapper.Map<UsuarioCursoResponse>(usuarioCurso);
            return usuarioCursoResponse;
        }

        public void InsertUsuarioCurso(PostUsuarioCursoRequest usuarioCurso)
        {
            var usuariopost = _mapper.Map<UsuarioCurso>(usuarioCurso);
            _repository.InsertUsuarioCurso(usuariopost);
        }

        public void UpdateUsuarioCurso(UpdateUsuarioCursoRequest usuarioCurso)
        {
            var usuarioCursoput = _mapper.Map<UsuarioCurso>(usuarioCurso);
            _repository.UpdateUsuarioCurso(usuarioCursoput);
        }
    }
}
