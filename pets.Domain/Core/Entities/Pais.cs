using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Pais
    {
        public Pais()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdPais { get; set; }
        public string NombrePais { get; set; }
        public string CodigoPais { get; set; }
        public int EstadoPais { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
