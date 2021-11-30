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
    public class PublicacionController : ControllerBase
    {
        private readonly IPublicacionRepository _publicacionRepository;

        private readonly IMapper _mapper;
        public PublicacionController(IPublicacionRepository publicacionRepository, IMapper mapper)
        {
            _publicacionRepository = publicacionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetPublicaciones")]
        public async Task<IActionResult> GetPublicaciones()
        {
            var publicaciones = await _publicacionRepository.GetPublicaciones();

            var publicacionesList = _mapper.Map<IEnumerable<PublicacionDTO>>(publicaciones);

            return Ok(publicacionesList);
        }

        //Buscar
        [HttpGet]
        [Route("GetPublicacionesById/{id}")]
        public async Task<IActionResult> GetPublicacionesById(int id)
        {
            var publicacion = await _publicacionRepository.GetPublicacionesById(id);
            if (publicacion == null)
                return NotFound();
            var publicacionDTO = _mapper.Map<PublicacionDTO>(publicacion);
            return Ok(publicacionDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostPublicacion")]
        public async Task<IActionResult> PostPublicacion(PublicacionPostDTO publicacionDTO)
        {
            var publicacion = _mapper.Map<Publicacion>(publicacionDTO);
            await _publicacionRepository.Insert(publicacion);
            return Ok(publicacion);
        }

        //Actualizar
        [HttpPut]
        [Route("PutPublicacion")]
        public async Task<IActionResult> PutPublicacion(PublicacionDTO publicacionDTO)
        {
            var publicacion = _mapper.Map<Publicacion>(publicacionDTO);
            await _publicacionRepository.Update(publicacion);
            return Ok(publicacion);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeletePublicacion")]
        public async Task<IActionResult> DeletePublicacion(int id)
        {
            var result = await _publicacionRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
