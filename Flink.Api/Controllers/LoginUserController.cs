using Flink.Application.Interfaces;
using Flink.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Flink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginUserController : ControllerBase
    {
        private readonly ILoginUsuarioService _Service;


        public LoginUserController(ILoginUsuarioService service)
        {
            _Service = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_Service.GetLoginUsuario());
        }

        [HttpGet("{IdAdmin}")]
        public ActionResult GetId([FromRoute] GetByIdLoginUserRequest request)
        {
            return Ok(_Service.GetLoginUsuarioById(request.IdAdmin));
        }

        [HttpPost]
        public IActionResult Post(PostUserLoginRequest request)
        {
            _Service.InsertLoginUsuario(request);
            return Ok();
        }
    }
}
