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
    public class CodigoController:ControllerBase
    {
        private readonly ICodigoRepository _codigoRepository;

        private readonly IMapper _mapper;
        public CodigoController(ICodigoRepository codigoRepository, IMapper mapper)
        {
            _codigoRepository = codigoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetCodigos")]
        public async Task<IActionResult> GetCodigos()
        {
            var codigos = await _codigoRepository.GetCodigos();

            var codigosList = _mapper.Map<IEnumerable<CodigoDTO>>(codigos);

            return Ok(codigosList);
        }

        //Buscar
        [HttpGet]
        [Route("GetCodigosById/{id}")]
        public async Task<IActionResult> GetCodigosById(int id)
        {
            var codigo = await _codigoRepository.GetCodigosById(id);
            if (codigo == null)
                return NotFound();
            var codigoDTO = _mapper.Map<CodigoDTO>(codigo);
            return Ok(codigoDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostCodigo")]
        public async Task<IActionResult> PostCodigo(CodigoPostDTO codigoDTO)
        {
            var codigo = _mapper.Map<Codigo>(codigoDTO);
            await _codigoRepository.Insert(codigo);
            return Ok(codigo);
        }

        //Actualizar
        [HttpPut]
        [Route("PutCodigo")]
        public async Task<IActionResult> PutCodigo(CodigoDTO codigoDTO)
        {
            var codigo = _mapper.Map<Codigo>(codigoDTO);
            await _codigoRepository.Update(codigo);
            return Ok(codigo);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteCodigo")]
        public async Task<IActionResult> DeleteCodigo(int id)
        {
            var result = await _codigoRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
