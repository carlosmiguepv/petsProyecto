using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Mascota
    {
        public Mascota()
        {
            Publicacion = new HashSet<Publicacion>();
        }

        public int IdMascota { get; set; }
        public string NombreMascota { get; set; }
        public string SexoMascota { get; set; }
        public string TamañoMascota { get; set; }
        public byte EdadMascota { get; set; }
        public int IdTipo { get; set; }
        public int EstadoMascota { get; set; }
        public string FotoMascota { get; set; }
        public int IdUsuario { get; set; }

        public virtual Tipo IdTipoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Publicacion> Publicacion { get; set; }
    }
}
