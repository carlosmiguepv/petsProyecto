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
    public class ComentarioController : ControllerBase
    {
        private readonly IComentarioRepository _comentarioRepository;

        private readonly IMapper _mapper;
        public ComentarioController(IComentarioRepository comentarioRepository, IMapper mapper)
        {
            _comentarioRepository = comentarioRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetComentarios")]
        public async Task<IActionResult> GetComentarios()
        {
            var comentarios = await _comentarioRepository.GetComentarios();

            var comentariosList = _mapper.Map<IEnumerable<ComentarioDTO>>(comentarios);

            return Ok(comentariosList);
        }

        //Buscar
        [HttpGet]
        [Route("GetComentariosById/{id}")]
        public async Task<IActionResult> GetComentariosById(int id)
        {
            var comentario = await _comentarioRepository.GetComentariosById(id);
            if (comentario == null)
                return NotFound();
            var comentarioDTO = _mapper.Map<ComentarioDTO>(comentario);
            return Ok(comentarioDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostComentario")]
        public async Task<IActionResult> PostComentario(ComentarioPostDTO comentarioDTO)
        {
            var comentario = _mapper.Map<Comentario>(comentarioDTO);
            await _comentarioRepository.Insert(comentario);
            return Ok(comentario);
        }

        //Actualizar
        [HttpPut]
        [Route("PutComentario")]
        public async Task<IActionResult> PutCodigo(ComentarioDTO comentarioDTO)
        {
            var comentario = _mapper.Map<Comentario>(comentarioDTO);
            await _comentarioRepository.Update(comentario);
            return Ok(comentario);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteComentario")]
        public async Task<IActionResult> DeleteComentario(int id)
        {
            var result = await _comentarioRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
