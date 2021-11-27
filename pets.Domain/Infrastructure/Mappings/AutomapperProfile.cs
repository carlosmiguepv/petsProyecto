using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using pets.Domain.Core.DTOs;
using pets.Domain.Core.Entities;

namespace pets.Domain.Infrastructure.Mappings
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {

            CreateMap<Administrador, AdministradorDTO>();
            CreateMap<AdministradorDTO, Administrador>();
        }
    }
}
