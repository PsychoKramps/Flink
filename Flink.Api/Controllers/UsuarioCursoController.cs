using AutoMapper;
using Flink.Application.Requests;
using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioCursoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioCursoRepository _repository;

        public UsuarioCursoController(IMapper mapper, IUsuarioCursoRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetUsuarioCursos());
        }

        [HttpGet("{UsuarioCursoId}")]
        public IActionResult GetUsuarioByID([FromRoute] GetByIdUsuarioCursoRequest request)
        {
            return Ok(_repository.GetUsuariosCursoById(request.UsuarioCursoId));
        }

        [HttpPost]

        public IActionResult post(UsuarioCurso usuarioCurso)
        {
            var Resultusuariocurso = _mapper.Map<UsuarioCurso>(usuarioCurso);
            _repository.InsertUsuarioCurso(usuarioCurso);

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(UpdateUsuarioCursoRequest request)
        {
            var usuariocurso = _mapper.Map<UsuarioCurso>(request);
            _repository.UpdateUsuarioCurso(usuariocurso);
            return Ok();
        }

        [HttpDelete("{UsuarioCursoId}")]
        public IActionResult Delete([FromRoute] DeleteUsuarioCursoRequest request)
        {
            _repository.DeleteUsuarioCurso(request.UsuarioCursoId);
            return Ok();
        }
    }
}
