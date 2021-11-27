using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Tipo
    {
        public Tipo()
        {
            Mascota = new HashSet<Mascota>();
        }

        public int IdTipo { get; set; }
        public int IdRaza { get; set; }
        public string NombreTipo { get; set; }
        public int EstadoTipo { get; set; }

        public virtual Raza IdRazaNavigation { get; set; }
        public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
