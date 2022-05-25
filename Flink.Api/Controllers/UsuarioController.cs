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
        private readonly IUsuarioRepository  _repository;
        public UsuarioController (IUsuarioRepository repository)
        { 
            _repository = repository; 
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_repository.GetUsuarios());
        }

    }
}
