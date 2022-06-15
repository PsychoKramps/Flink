using AutoMapper;
using Flink.Application.Inferfaces;
using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;

namespace Flink.Application.Services
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _repository;
        private readonly IMapper _mapper;

        public  CursoService(ICursoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCursos(DeleteCursoRequest request)
        {
            _repository.DeleteCursos(request.Codigo);
        }

        public IEnumerable<CursoResponse> GetCursos()
        {
            var curso = _repository.GetCursos();
            var cursoResponse = _mapper.Map<IEnumerable<CursoResponse>>(curso);
            return cursoResponse;
        }

        public CursoResponse GetCursosId(int codigo)
        {
            var curso = _repository.GetCursosId(codigo);
            var cursoResponse = _mapper.Map<CursoResponse>(curso);
            return cursoResponse;
        }

        public void InsertCurso(PostCursoRequest curso)
        {
            var cursoPost = _mapper.Map<Curso>(curso);
            _repository.InsertCurso(cursoPost);
        }

        public void UpdateCursos(PutCursoRequest curso)
        {
            var CursoPut = _mapper.Map<Curso>(curso);
            _repository.UpdateCursos(CursoPut);
        }
    }
}
