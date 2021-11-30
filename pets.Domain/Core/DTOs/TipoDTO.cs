using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class TipoDTO
    {
        public int IdTipo { get; set; }
        public int IdRaza { get; set; }
        public string NombreTipo { get; set; }
        public int EstadoTipo { get; set; }
    }

    public class TipoPostDTO
    {
        public int IdRaza { get; set; }
        public string NombreTipo { get; set; }
        public int EstadoTipo { get; set; }
    }
}
