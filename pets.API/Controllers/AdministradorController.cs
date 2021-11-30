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
    public class AdministradorController : ControllerBase
    {
        private readonly IAdministradorRepository _administradorRepository;

        private readonly IMapper _mapper;
        public AdministradorController(IAdministradorRepository administradorRepository,IMapper mapper)
        {
            _administradorRepository = administradorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAdministradores")]
        public async Task<IActionResult> GetAdministradores()
        {
            var administradores = await _administradorRepository.GetAdministradores();
            
            var administradoresList = _mapper.Map<IEnumerable<AdministradorDTO>>(administradores);

            return Ok(administradoresList);
        }

        //Buscar
        [HttpGet]
        [Route("GetAdministradoresById/{id}")]
        public async Task<IActionResult> GetAdministradoresById(int id)
        {
            var administrador = await _administradorRepository.GetAdministradoresById(id);
            if (administrador == null)
                return NotFound();
            var administradorDTO = _mapper.Map<AdministradorDTO>(administrador);
            return Ok(administradorDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostAdministrador")]
        public async Task<IActionResult> PostCustomer(AdministradorPostDTO administradorDTO)
        {
            var administrador = _mapper.Map<Administrador>(administradorDTO);
            await _administradorRepository.Insert(administrador);
            return Ok(administrador);
        }

        //Actualizar
        [HttpPut]
        [Route("PutAdministrador")]
        public async Task<IActionResult> PutCustomer(AdministradorDTO administradorDTO)
        {
            var administrador = _mapper.Map<Administrador>(administradorDTO);
            await _administradorRepository.Update(administrador);
            return Ok(administrador);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteAdministrador")]
        public async Task<IActionResult> DeleteAdministrador(int id)
        {
            var result = await _administradorRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
