using AutoMapper;
using Flink.Application.Interfaces;
using Flink.Application.Requests;
using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace Flink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioCursoController : ControllerBase
    {
        private readonly ICursoUsuarioService _Service;
        public UsuarioCursoController(ICursoUsuarioService service)
        {
            _Service = service;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_Service.GetUsuarioCursos());
        }

        [HttpGet("{UsuarioCursoId}")]
        public IActionResult GetUsuarioByID([FromRoute] GetByIdUsuarioCursoRequest request)
        {
            return Ok(_Service.GetUsuariosCursoById(request.UsuarioCursoId));
        }

        [HttpPost]

        public IActionResult post(PostUsuarioCursoRequest request)
        {
            _Service.InsertUsuarioCurso(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateUsuarioCursoRequest request)
        {
            _Service.UpdateUsuarioCurso(request);
            return Ok();
        }

        [HttpDelete("{UsuarioCursoId}")]
        public IActionResult Delete([FromRoute] DeleteUsuarioCursoRequest request)
        {
            _Service.DeleteUsuarioCurso(request);
            return Ok();
        }
    }
}
