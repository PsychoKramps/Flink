using AutoMapper;
using Flink.Application.Requests;
using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace Flink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICursoRepository _repository;
        public CursoController(ICursoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_repository.GetCursos());
        }

        [HttpGet("{id}")]
        public ActionResult GetId(int id)
        {
            return Ok(_repository.GetCursosId(id));
        }

        [HttpPost]
        public IActionResult Post(PostCursoRequest request)
        {
            var curso = _mapper.Map<Curso>(request);
            _repository.InsertCurso(curso);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(PutCursoRequest request)
        {
            var curso = _mapper.Map<Curso>(request);
            _repository.UpdateCursos(curso);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _repository.DeleteCursos(id);
            return Ok();
        }
    }
}
