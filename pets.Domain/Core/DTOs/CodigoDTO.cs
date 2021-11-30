using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class CodigoDTO
    {
        public int IdCodigo { get; set; }
        public string DatoCodigo { get; set; }
        public int CantidadCodigo { get; set; }
        public byte EstadoCodigo { get; set; }
        public int IdSponsor { get; set; }
    }

    public class CodigoPostDTO
    {
        public int IdCodigo { get; set; }
        public string DatoCodigo { get; set; }
        public int CantidadCodigo { get; set; }
        public int IdSponsor { get; set; }
    }
    public class codigo48DTO
    {
        public int CantidadCodigo { get; set; }
    }

}
