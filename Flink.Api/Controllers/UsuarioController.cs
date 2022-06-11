using AutoMapper;
using Flink.Application.Requests;
using Flink.Application.Services;
using Flink.Domain.Application;
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
        
        private readonly IUsuarioService _Service;
        public UsuarioController(IUsuarioService Service)
        {
            _Service = Service;
            
                
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_Service.GetUsuarios());
        }


        [HttpGet("{IdUsuario}")]
        public IActionResult GetUsuarioByID([FromRoute] GetUsuarioByIDRequest request)
        {
            return Ok(_Service.GetUsuariosById(request.IdUsuario));
        }

        [HttpPost]
        public IActionResult Post(CreateUsuarioRequest usuario)
        {            
            _Service.InsertUsuario(usuario);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateUsuarioRequest request)
        {
            _Service.UpdateUsuario(request);
            return Ok();
        }

        [HttpDelete("{IdUsuario}")]
        public IActionResult Delete([FromRoute] DeleteUsuarioRequest request)
        {
            _Service.DeleteUsuario(request);
            return Ok();
        }
    }
}