using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Adoptar
    {
        public int IdAdoptar { get; set; }
        public int IdAdministrador { get; set; }
        public int IdUsuario { get; set; }
        public string DocumentoAdoptar { get; set; }
        public int EstadoAdoptar { get; set; }

        public virtual Administrador IdAdministradorNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
