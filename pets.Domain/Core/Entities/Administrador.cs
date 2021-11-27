using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Administrador
    {
        public Administrador()
        {
            Adoptar = new HashSet<Adoptar>();
            Publicacion = new HashSet<Publicacion>();
        }

        public int IdAdministrador { get; set; }
        public string NombreAdministrador { get; set; }
        public string ApellidoAdministrador { get; set; }
        public string CelularAdministrador { get; set; }
        public string DirecciónUsuario { get; set; }
        public DateTime? FechaNacimientoAdministrador { get; set; }
        public string CorreoAdministrador { get; set; }
        public string ContraseñaAdministrador { get; set; }
        public bool? GeneroAdministrador { get; set; }
        public byte[] FotoAdministrador { get; set; }
        public int EstadoAdministrador { get; set; }

        public virtual ICollection<Adoptar> Adoptar { get; set; }
        public virtual ICollection<Publicacion> Publicacion { get; set; }
    }
}
