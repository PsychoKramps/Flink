using Flink.Application.Inferfaces;
using Flink.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Flink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _Service;
        public CursoController(ICursoService service)
        {
            _Service = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_Service.GetCursos());
        }

        [HttpGet("{Codigo}")]
        public ActionResult GetId([FromRoute] GetByIdCursoRequest request)
        {
            return Ok(_Service.GetCursosId(request.Codigo));
        }

        [HttpPost]
        public IActionResult Post(PostCursoRequest request)
        {
            _Service.InsertCurso(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(PutCursoRequest request)
        {
            _Service.UpdateCursos(request);
            return Ok();
        }

        [HttpDelete("{Codigo}")]
        public ActionResult Delete([FromRoute] DeleteCursoRequest request)
        {
            _Service.DeleteCursos(request);
            return Ok();
        }
    }
}
