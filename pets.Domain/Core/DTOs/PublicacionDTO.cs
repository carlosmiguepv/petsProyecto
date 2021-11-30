using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class PublicacionDTO
    {
        public int IdPublicacion { get; set; }
        public int IdAdministrador { get; set; }
        public int IdUsuario { get; set; }
        public int IdMascota { get; set; }
        public string MensajePublicacion { get; set; }
        public int NLikesPublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Estado { get; set; }
    }

    public class PublicacionPostDTO
    {
        public int IdAdministrador { get; set; }
        public int IdUsuario { get; set; }
        public int IdMascota { get; set; }
        public string MensajePublicacion { get; set; }
        public int NLikesPublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Estado { get; set; }
    }

    public class publicacionlDTO
    {
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion21DTO
    {
        public string MensajePublicacion { get; set; }
        public int NLikesPublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion26DTO
    {
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion27DTO
    {
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion28DTO
    {
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion29DTO
    {
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion30DTO
    {
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion3lDTO
    {
        public string MensajePublicacion { get; set; }
        public int NLikesPublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion37DTO
    {
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion4lDTO
    {
        public string MensajePublicacion { get; set; }
        public int NLikesPublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion42DTO
    {
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion43DTO
    {
        public string MensajePublicacion { get; set; }
        public int NLikesPublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
    public class publicacion47DTO
    {
        public DateTime FechaPublicacion { get; set; }
    }

}
