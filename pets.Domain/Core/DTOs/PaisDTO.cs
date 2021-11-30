using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class PaisDTO
    {
        public int IdPais { get; set; }
        public string NombrePais { get; set; }
        public string CodigoPais { get; set; }
        public int EstadoPais { get; set; }
    }

    public class PaisPostDTO
    {
        public string NombrePais { get; set; }
        public string CodigoPais { get; set; }
    }
}
