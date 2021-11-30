using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pets.Domain.Core.DTOs;
using pets.Domain.Core.Entities;
using pets.Domain.Core.Interfaces;

namespace pets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly IMapper _mapper;
        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetUsuarios")]
        public async Task<IActionResult> GetUsuarios()
        {
            var usuarios = await _usuarioRepository.GetUsuarios();

            var usuariosList = _mapper.Map<IEnumerable<UsuarioDTO>>(usuarios);

            return Ok(usuariosList);
        }

        //Buscar
        [HttpGet]
        [Route("GetUsuariosById/{id}")]
        public async Task<IActionResult> GetUsuariosById(int id)
        {
            var usuario = await _usuarioRepository.GetUsuariosById(id);
            if (usuario == null)
                return NotFound();
            var usuarioDTO = _mapper.Map<UsuarioDTO>(usuario);
            return Ok(usuarioDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostUsuario")]
        public async Task<IActionResult> PostUsuario(UsuarioPostDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            await _usuarioRepository.Insert(usuario);
            return Ok(usuario);
        }

        //Actualizar
        [HttpPut]
        [Route("PutUsuario")]
        public async Task<IActionResult> PutUsuario(UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            await _usuarioRepository.Update(usuario);
            return Ok(usuario);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteUsuario")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var result = await _usuarioRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
