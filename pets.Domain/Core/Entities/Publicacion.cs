using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Publicacion
    {
        public int IdPublicacion { get; set; }
        public int IdAdministrador { get; set; }
        public int IdUsuario { get; set; }
        public int IdMascota { get; set; }
        public string MensajePublicacion { get; set; }
        public int NLikesPublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Estado { get; set; }

        public virtual Administrador IdAdministradorNavigation { get; set; }
        public virtual Mascota IdMascotaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
