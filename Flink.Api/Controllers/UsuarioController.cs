using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetUsuarios());
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Usuario = _repository.GetUsuarios(id);

            return Ok(Usuario);
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
           _repository.InsertUsuario(usuario);

            return Ok();
        }
    }
}
