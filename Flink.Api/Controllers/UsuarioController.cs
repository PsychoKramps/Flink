﻿using AutoMapper;
using Flink.Application.Requests;
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
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _repository;
        public UsuarioController(IUsuarioRepository repository, IMapper mapper)
        {   _mapper = mapper;
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
            var curso = _mapper.Map<Usuario>(usuario);
           _repository.InsertUsuario(usuario);

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(UpdateUsuarioRequest request)
        {
            var usuario = _mapper.Map<Usuario>(request);
            _repository.UpdateUsuario(usuario);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _repository.DeleteUsuario(id);
            return Ok();
        }
    }
}
