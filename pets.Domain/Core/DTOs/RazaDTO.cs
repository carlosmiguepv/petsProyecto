using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class RazaDTO
    {
        public int IdRaza { get; set; }
        public string NombreRaza { get; set; }
        public int EstadoRaza { get; set; }
    }
    public class RazaPostDTO
    {
        public string NombreRaza { get; set; }
        public int EstadoRaza { get; set; }
    }
}
