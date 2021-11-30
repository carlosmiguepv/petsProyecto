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
            CreateMap<Adoptar, AdoptarDTO>();
            CreateMap<AdoptarDTO, Adoptar>();
            CreateMap<Codigo, CodigoDTO>();
            CreateMap<CodigoDTO, Codigo>();
            CreateMap<Comentario, ComentarioDTO>();
            CreateMap<ComentarioDTO, Comentario>();
            CreateMap<Mascota, MascotaDTO>();
            CreateMap<MascotaDTO, Mascota>();
            CreateMap<Pais, PaisDTO>();
            CreateMap<PaisDTO, Pais>();
            CreateMap<Publicacion, PublicacionDTO>();
            CreateMap<PublicacionDTO, Publicacion>();
            CreateMap<Raza, RazaDTO>();
            CreateMap<RazaDTO, Raza>();
            CreateMap<Sponsor, SponsorDTO>();
            CreateMap<SponsorDTO, Sponsor>();
            CreateMap<Tipo, TipoDTO>();
            CreateMap<TipoDTO, Tipo>();
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();
        }
    }
}
