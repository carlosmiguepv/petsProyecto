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
    public class SponsorController : ControllerBase
    {
        private readonly ISponsorRepository _sponsorRepository;

        private readonly IMapper _mapper;
        public SponsorController(ISponsorRepository sponsorRepository, IMapper mapper)
        {
            _sponsorRepository = sponsorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetSponsors")]
        public async Task<IActionResult> GetSponsors()
        {
            var sponsors = await _sponsorRepository.GetSponsors();

            var sponsorsList = _mapper.Map<IEnumerable<SponsorDTO>>(sponsors);

            return Ok(sponsorsList);
        }

        //Buscar
        [HttpGet]
        [Route("GetSponsorsById/{id}")]
        public async Task<IActionResult> GetSponsorsById(int id)
        {
            var sponsor = await _sponsorRepository.GetSponsorsById(id);
            if (sponsor == null)
                return NotFound();
            var sponsorDTO = _mapper.Map<SponsorDTO>(sponsor);
            return Ok(sponsorDTO);
        }

        //Agregar
        [HttpPost]
        [Route("PostSponsor")]
        public async Task<IActionResult> PostSponsor(SponsorPostDTO sponsorDTO)
        {
            var sponsor = _mapper.Map<Sponsor>(sponsorDTO);
            await _sponsorRepository.Insert(sponsor);
            return Ok(sponsor);
        }

        //Actualizar
        [HttpPut]
        [Route("PutSponsor")]
        public async Task<IActionResult> PutSponsor(SponsorDTO sponsorDTO)
        {
            var sponsor = _mapper.Map<Sponsor>(sponsorDTO);
            await _sponsorRepository.Update(sponsor);
            return Ok(sponsor);
        }

        //Eliminar
        [HttpDelete]
        [Route("DeleteSponsor")]
        public async Task<IActionResult> DeleteSponsor(int id)
        {
            var result = await _sponsorRepository.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
