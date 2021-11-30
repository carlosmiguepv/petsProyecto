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
    public class AdoptarController: ControllerBase
    {
        private readonly IAdoptarRepository _adoptarRepository;

        private readonly IMapper _mapper;
        public AdoptarController(IAdoptarRepository adoptarRepository, IMapper mapper)
        {
            _adoptarRepository = adoptarRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAdoptars")]
        public async Task<IActionResult> GetAdoptars()
        {
            var adoptars = await _adoptarRepository.GetAdoptars();

            var adoptarsList = _mapper.Map<IEnumerable<AdoptarDTO>>(adoptars);

            return Ok(adoptarsList);
        }

        //Buscar
        [HttpGet]
        [Route("GetAdoptarsById/{id}")]
        public async Task<IActionResult> GetAdoptarsById(int id)
        {
            var adoptar = await _adoptarRepository.GetAdoptarsById(id);
            if (adoptar == null)
                return NotFound();
            var adoptarDTO = _mapper.Map<AdoptarDTO>(adoptar);
            return Ok(adoptarDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostAdoptar")]
        public async Task<IActionResult> PostAdopter(AdoptarPostDTO adoptarDTO)
        {
            var adoptar = _mapper.Map<Adoptar>(adoptarDTO);
            await _adoptarRepository.Insert(adoptar);
            return Ok(adoptar);
        }

        //Actualizar
        [HttpPut]
        [Route("PutAdministrador")]
        public async Task<IActionResult> PutAdoptor(AdoptarDTO adoptarDTO)
        {
            var adoptar = _mapper.Map<Adoptar>(adoptarDTO);
            await _adoptarRepository.Update(adoptar);
            return Ok(adoptar);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteAdoptar")]
        public async Task<IActionResult> DeleteAdoptar(int id)
        {
            var result = await _adoptarRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
