using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Domain.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Flink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService _Service;
        public UsuarioController(IUsuarioService Service)
        {
            _Service = Service;
        }

        /// <summary>
        /// Retorna un listado con todas los usuarios registradoss
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<UsuarioResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]
        public IActionResult Get()
        {
            return Ok(_Service.GetUsuarios());
        }




        /// <summary>
        /// Permite consultar la información de una sala por su id
        /// </summary>
        /// <param name="request">Identificador de la sala a buscar</param>
        /// <returns></returns>
        [HttpGet("{IdUsuario}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(UsuarioResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]

        public IActionResult GetUsuarioByID([FromRoute] GetUsuarioByIDRequest request)
        {
            return Ok(_Service.GetUsuariosById(request.IdUsuario));
        }

        /// <summary>
        /// Permite insertar una sala
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(CreateUsuarioRequest usuario)
        {
            _Service.InsertUsuario(usuario);
            return Ok();
        }

        /// <summary>
        /// Cambia cualquier dato de un Usuario de la lista.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(UpdateUsuarioRequest request)
        {
            _Service.UpdateUsuario(request);
            return Ok();
        }

        /// <summary>
        /// Elimina Usuarios de la lista.
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{IdUsuario}")]
        public IActionResult Delete([FromRoute] DeleteUsuarioRequest request)
        {
            _Service.DeleteUsuario(request);
            return Ok();
        }
    }
}