using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pets.Domain.Core.DTOs;
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

            //var adoptarsList = _mapper.Map<IEnumerable<AdministradorDTO>>(adoptars);

            return Ok(adoptars);
        }
    }
}
