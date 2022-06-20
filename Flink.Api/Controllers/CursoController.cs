using Flink.Application.Inferfaces;
using Flink.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Flink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _Service;
        public CursoController(ICursoService service)
        {
            _Service = service;
        }

        /// <summary>
        /// Retorna un listado con todos los cursos registrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_Service.GetCursos());
        }

        /// <summary>
        /// Retorna un listado con los cursos registrados filtrados por Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{Codigo}")]
        public ActionResult GetId([FromRoute] GetByIdCursoRequest request)
        {
            return Ok(_Service.GetCursosId(request.Codigo));
        }

        /// <summary>
        /// Agrega cursos a la lista
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(PostCursoRequest request)
        {
            _Service.InsertCurso(request);
            return Ok();
        }

        /// <summary>
        /// Cambia cualquier dato de un curso de la lista.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(PutCursoRequest request)
        {
            _Service.UpdateCursos(request);
            return Ok();
        }
        /// <summary>
        /// Elimina cursos de la lista.
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{Codigo}")]
        public ActionResult Delete([FromRoute] DeleteCursoRequest request)
        {
            _Service.DeleteCursos(request);
            return Ok();
        }
    }
}
