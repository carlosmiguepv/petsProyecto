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


    public class publicacion
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

}
