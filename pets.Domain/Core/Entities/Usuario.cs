using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Adoptar = new HashSet<Adoptar>();
            Comentario = new HashSet<Comentario>();
            Mascota = new HashSet<Mascota>();
            Publicacion = new HashSet<Publicacion>();
        }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string CelularUsuario { get; set; }
        public string DirecciónUsuario { get; set; }
        public int IdPais { get; set; }
        public DateTime FechaNacimientoUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
        public bool? GeneroUsuario { get; set; }
        public string FotoUsuario { get; set; }
        public int EstadoUsuario { get; set; }

        public virtual Pais IdPaisNavigation { get; set; }
        public virtual ICollection<Adoptar> Adoptar { get; set; }
        public virtual ICollection<Comentario> Comentario { get; set; }
        public virtual ICollection<Mascota> Mascota { get; set; }
        public virtual ICollection<Publicacion> Publicacion { get; set; }
    }
}
