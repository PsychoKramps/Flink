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
        private readonly ICursoRepository _repository;
        public CursoController(ICursoRepository repository)
        {
            _repository = repository;
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
        public IActionResult Post(CursoRequest request)
        {
            var curso = new Curso
            {
                NombreCurso = request.NombreCurso,
                UrlCurso = request.UrlCurso,
                Fecha  = request.Fecha,
                Duracion = request.Duracion,
                Descripcion = request.Descripcion,
                TipoCurso = request.TipoCurso,
                Categoria = request.Categoria,
            };

            _repository.InsertCurso(curso);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(CursoRequest request)
        {
            var curso = new Curso
            {
                Codigo = request.Codigo,
                NombreCurso=request.NombreCurso,
                UrlCurso=request.UrlCurso,
                Fecha=request.Fecha,
                Duracion=request.Duracion,
                Descripcion=request.Descripcion,
                TipoCurso=request.TipoCurso,
                Categoria=request.Categoria,
            };

            _repository.UpdateCursos(curso);
            return Ok();
        }
    }
}
