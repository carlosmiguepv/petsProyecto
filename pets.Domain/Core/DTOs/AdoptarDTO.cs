using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class AdoptarDTO
    {
        public int IdAdoptar { get; set; }
        public int IdAdministrador { get; set; }
        public int IdUsuario { get; set; }
        public string DocumentoAdoptar { get; set; }
        public int EstadoAdoptar { get; set; }
    }

    public class AdoptarPostDTO
    {
        public int IdAdministrador { get; set; }
        public int IdUsuario { get; set; }
        public string DocumentoAdoptar { get; set; }
    }
}
