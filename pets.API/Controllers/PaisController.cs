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
    public class PaisController : ControllerBase
    {
        private readonly IPaisRepository _paisRepository;

        private readonly IMapper _mapper;
        public PaisController(IPaisRepository paisRepository, IMapper mapper)
        {
            _paisRepository = paisRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetPaises")]
        public async Task<IActionResult> GetPaises()
        {
            var paises = await _paisRepository.GetPaises();

            var paisesList = _mapper.Map<IEnumerable<PaisDTO>>(paises);

            return Ok(paises);
        }

        //Buscar
        [HttpGet]
        [Route("GetPaisesById/{id}")]
        public async Task<IActionResult> GetPaisesById(int id)
        {
            var pais = await _paisRepository.GetPaisesById(id);
            if (pais == null)
                return NotFound();
            var paisDTO = _mapper.Map<CodigoDTO>(pais);
            return Ok(paisDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostPais")]
        public async Task<IActionResult> PostPais(PaisPostDTO paisDTO)
        {
            var pais = _mapper.Map<Pais>(paisDTO);
            await _paisRepository.Insert(pais);
            return Ok(pais);
        }

        //Actualizar
        [HttpPut]
        [Route("PutPais")]
        public async Task<IActionResult> PutPais(PaisDTO paisDTO)
        {
            var pais = _mapper.Map<Pais>(paisDTO);
            await _paisRepository.Update(pais);
            return Ok(pais);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeletePais")]
        public async Task<IActionResult> DeletePais(int id)
        {
            var result = await _paisRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
