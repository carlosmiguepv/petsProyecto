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
            CreateMap<Adoptar, adoptar27DTO>();
            CreateMap<adoptar27DTO, Adoptar>(); 

            CreateMap<Adoptar, adoptar44DTO>();
            CreateMap<adoptar44DTO, Adoptar>();

            CreateMap<Codigo, codigo48DTO>();
            CreateMap<codigo48DTO, Codigo>();

            CreateMap<Mascota, Mascota10DTO>();
            CreateMap<Mascota10DTO, Mascota>();

            CreateMap<Mascota, Mascota21DTO>();
            CreateMap<Mascota21DTO, Mascota>();

            CreateMap<Mascota, Mascota26DTO>();
            CreateMap<Mascota26DTO, Mascota>();

            CreateMap<Mascota, Mascota27DTO>();
            CreateMap<Mascota27DTO, Mascota>();

            CreateMap<Mascota, Mascota28DTO>();
            CreateMap<Mascota28DTO, Mascota>();

            CreateMap<Mascota, Mascota29DTO>();
            CreateMap<Mascota29DTO, Mascota>();

            CreateMap<Mascota, Mascota30DTO>();
            CreateMap<Mascota30DTO, Mascota>();

            CreateMap<Mascota, Mascota31DTO>();
            CreateMap<Mascota31DTO, Mascota>();

            CreateMap<Mascota, Mascota37DTO>();
            CreateMap<Mascota37DTO, Mascota>();

            CreateMap<Mascota, Mascota40DTO>();
            CreateMap<Mascota40DTO, Mascota>();

            CreateMap<Mascota, Mascota41DTO>();
            CreateMap<Mascota41DTO, Mascota>();

            CreateMap<Pais, pais8DTO>();
            CreateMap<pais8DTO, Pais>();

            CreateMap<Pais, pais11DTO>();
            CreateMap<pais11DTO, Pais>();

            CreateMap<Pais, pais12DTO>();
            CreateMap<pais12DTO, Pais>();

            CreateMap<Pais, pais13DTO>();
            CreateMap<pais13DTO, Pais>();

            CreateMap<Pais, pais14DTO>();
            CreateMap<pais14DTO, Pais>();

            CreateMap<Pais, pais15DTO>();
            CreateMap<pais15DTO, Pais>();

            CreateMap<Pais, pais16DTO>();
            CreateMap<pais16DTO, Pais>();

            CreateMap<Pais, pais17DTO>();
            CreateMap<pais17DTO, Pais>();

            CreateMap<Pais, pais19DTO>();
            CreateMap<pais19DTO, Pais>();

            CreateMap<Pais, pais20DTO>();
            CreateMap<pais20DTO, Pais>();

            CreateMap<Pais, pais21DTO>();
            CreateMap<pais21DTO, Pais>();

            CreateMap<Pais, pais22DTO>();
            CreateMap<pais22DTO, Pais>();

            CreateMap<Pais, pais27DTO>();
            CreateMap<pais27DTO, Pais>();

            CreateMap<Publicacion, publicacionlDTO>();
            CreateMap<publicacionlDTO, Publicacion>();

            CreateMap<Publicacion, publicacion21DTO>();
            CreateMap<publicacion21DTO, Publicacion>();

            CreateMap<Publicacion, publicacion26DTO>();
            CreateMap<publicacion26DTO, Publicacion>();

            CreateMap<Publicacion, publicacion27DTO>();
            CreateMap<publicacion27DTO, Publicacion>();

            CreateMap<Publicacion, publicacion28DTO>();
            CreateMap<publicacion28DTO, Publicacion>();

            CreateMap<Publicacion, publicacion29DTO>();
            CreateMap<publicacion29DTO, Publicacion>();

            CreateMap<Publicacion, publicacion30DTO>();
            CreateMap<publicacion30DTO, Publicacion>();

            CreateMap<Publicacion, publicacion3lDTO>();
            CreateMap<publicacion3lDTO, Publicacion>();

            CreateMap<Publicacion, publicacion37DTO>();
            CreateMap<publicacion37DTO, Publicacion>();

            CreateMap<Publicacion, publicacion4lDTO>();
            CreateMap<publicacion4lDTO, Publicacion>();

            CreateMap<Publicacion, publicacion42DTO>();
            CreateMap<publicacion42DTO, Publicacion>();

            CreateMap<Publicacion, publicacion43DTO>();
            CreateMap<publicacion43DTO, Publicacion>();

            CreateMap<Publicacion, publicacion47DTO>();
            CreateMap<publicacion47DTO, Publicacion>();

            CreateMap<Raza, raza21DTO>();
            CreateMap<raza21DTO, Raza>();

            CreateMap<Raza, raza26DTO>();
            CreateMap<raza26DTO, Raza>();

            CreateMap<Raza, raza27DTO>();
            CreateMap<raza27DTO, Raza>();

            CreateMap<Raza, raza28DTO>();
            CreateMap<raza28DTO, Raza>();

            CreateMap<Raza, raza29DTO>();
            CreateMap<raza29DTO, Raza>();

            CreateMap<Raza, raza30DTO>();
            CreateMap<raza30DTO, Raza>();

            CreateMap<Raza, raza31DTO>();
            CreateMap<raza31DTO, Raza>();

            CreateMap<Raza, raza41DTO>();
            CreateMap<raza41DTO, Raza>();

            CreateMap<Raza, raza43DTO>();
            CreateMap<raza43DTO, Raza>();

            CreateMap<Sponsor, sponsor46DTO>();
            CreateMap<sponsor46DTO, Sponsor>();

            CreateMap<Tipo,tipo26DTO>();
            CreateMap<tipo26DTO, Tipo>();

            CreateMap<Tipo, tipo27DTO>();
            CreateMap<tipo27DTO, Tipo>();

            CreateMap<Tipo, tipo28DTO>();
            CreateMap<tipo28DTO, Tipo>(); 

            CreateMap<Tipo, tipo29DTO>();
            CreateMap<tipo29DTO, Tipo>();

            CreateMap<Tipo, tipo30DTO>();
            CreateMap<tipo30DTO, Tipo>();

            CreateMap<Tipo, tipo31DTO>();
            CreateMap<tipo31DTO, Tipo>();

            CreateMap<Tipo, tipo41DTO>();
            CreateMap<tipo41DTO, Tipo>();

            CreateMap<Tipo, tipo43DTO>();
            CreateMap<tipo43DTO, Tipo>();

            CreateMap<Usuario, usuario11DTO>();
            CreateMap<usuario11DTO, Usuario>();

            CreateMap<Usuario, usuario12DTO>();
            CreateMap<usuario12DTO, Usuario>();

            CreateMap<Usuario, usuario13DTO>();
            CreateMap<usuario13DTO, Usuario>();

            CreateMap<Usuario, usuario14DTO>();
            CreateMap<usuario14DTO, Usuario>();

            CreateMap<Usuario, usuario15DTO>();
            CreateMap<usuario15DTO, Usuario>();

            CreateMap<Usuario, usuario16DTO>();
            CreateMap<usuario16DTO, Usuario>();

            CreateMap<Usuario, usuario17DTO>();
            CreateMap<usuario17DTO, Usuario>();

            CreateMap<Usuario, usuario18DTO>();
            CreateMap<usuario18DTO, Usuario>();

            CreateMap<Usuario, usuario19DTO>();
            CreateMap<usuario19DTO, Usuario>();

            CreateMap<Usuario, usuario20DTO>();
            CreateMap<usuario20DTO, Usuario>();

            CreateMap<Usuario, usuario21DTO>();
            CreateMap<usuario21DTO, Usuario>();

            CreateMap<Usuario, usuario22DTO>();
            CreateMap<usuario22DTO, Usuario>();

            CreateMap<Usuario, Usuario27DTO>();
            CreateMap<Usuario27DTO, Usuario>();

            CreateMap<Usuario, usuario34DTO>();
            CreateMap<usuario34DTO, Usuario>();

            CreateMap<Usuario, usuario39DTO>();
            CreateMap<usuario39DTO, Usuario>();



        }
    }
}
