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
    public class RazaController : ControllerBase
    {
        private readonly IRazaRepository _razaRepository;

        private readonly IMapper _mapper;
        public RazaController(IRazaRepository razaRepository, IMapper mapper)
        {
            _razaRepository = razaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetRazas")]
        public async Task<IActionResult> GetRazas()
        {
            var razas = await _razaRepository.GetRazas();

            var razasList = _mapper.Map<IEnumerable<RazaDTO>>(razas);

            return Ok(razasList);
        }

        //Buscar
        [HttpGet]
        [Route("GetRazasById/{id}")]
        public async Task<IActionResult> GetRazasById(int id)
        {
            var raza = await _razaRepository.GetRazasById(id);
            if (raza == null)
                return NotFound();
            var razaDTO = _mapper.Map<RazaDTO>(raza);
            return Ok(razaDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostRaza")]
        public async Task<IActionResult> PostRaza(RazaPostDTO razaDTO)
        {
            var raza = _mapper.Map<Raza>(razaDTO);
            await _razaRepository.Insert(raza);
            return Ok(raza);
        }

        //Actualizar
        [HttpPut]
        [Route("PutRaza")]
        public async Task<IActionResult> PutRaza(CodigoDTO razaDTO)
        {
            var raza = _mapper.Map<Raza>(razaDTO);
            await _razaRepository.Update(raza);
            return Ok(raza);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteRaza")]
        public async Task<IActionResult> DeleteRaza(int id)
        {
            var result = await _razaRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
