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
    public class MascotaController : ControllerBase
    {
        private readonly IMascotaRepository _mascotaRepository;

        private readonly IMapper _mapper;
        public MascotaController(IMascotaRepository mascotaRepository, IMapper mapper)
        {
            _mascotaRepository = mascotaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetMascotas")]
        public async Task<IActionResult> GetMascotas()
        {
            var mascotas = await _mascotaRepository.GetMascotas();

            var mascotasList = _mapper.Map<IEnumerable<CodigoDTO>>(mascotas);

            return Ok(mascotasList);
        }

        //Buscar
        [HttpGet]
        [Route("GetMascotasById/{id}")]
        public async Task<IActionResult> GetMascotasById(int id)
        {
            var mascota = await _mascotaRepository.GetMascotasById(id);
            if (mascota == null)
                return NotFound();
            var mascotaDTO = _mapper.Map<MascotaDTO>(mascota);
            return Ok(mascotaDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostMascota")]
        public async Task<IActionResult> PostMascota(MascotaPostDTO mascotaDTO)
        {
            var mascota = _mapper.Map<Mascota>(mascotaDTO);
            await _mascotaRepository.Insert(mascota);
            return Ok(mascota);
        }

        //Actualizar
        [HttpPut]
        [Route("PutMascota")]
        public async Task<IActionResult> PutMascota(MascotaDTO mascotaDTO)
        {
            var mascota = _mapper.Map<Mascota>(mascotaDTO);
            await _mascotaRepository.Update(mascota);
            return Ok(mascota);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteMascota")]
        public async Task<IActionResult> DeleteMascota(int id)
        {
            var result = await _mascotaRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
