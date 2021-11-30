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
    public class TipoController : ControllerBase
    {
        private readonly ITipoRepository _tipoRepository;

        private readonly IMapper _mapper;
        public TipoController(ITipoRepository tipoRepository, IMapper mapper)
        {
            _tipoRepository = tipoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetTipos")]
        public async Task<IActionResult> GetTipos()
        {
            var tipos = await _tipoRepository.GetTipos();

            var tiposList = _mapper.Map<IEnumerable<TipoDTO>>(tipos);

            return Ok(tiposList);
        }   

        //Buscar
        [HttpGet]
        [Route("GetTiposById/{id}")]
        public async Task<IActionResult> GetTiposById(int id)
        {
            var tipo = await _tipoRepository.GetTiposById(id);
            if (tipo == null)
                return NotFound();
            var tipoDTO = _mapper.Map<TipoDTO>(tipo);
            return Ok(tipoDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostTipo")]
        public async Task<IActionResult> PostTipo(TipoPostDTO tipoDTO)
        {
            var tipo = _mapper.Map<Tipo>(tipoDTO);
            await _tipoRepository.Insert(tipo);
            return Ok(tipo);
        }

        //Actualizar
        [HttpPut]
        [Route("PutTipo")]
        public async Task<IActionResult> PutTipo(TipoDTO tipoDTO)
        {
            var tipo = _mapper.Map<Tipo>(tipoDTO);
            await _tipoRepository.Update(tipo);
            return Ok(tipo);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteTipo")]
        public async Task<IActionResult> DeleteTipo(int id)
        {
            var result = await _tipoRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
