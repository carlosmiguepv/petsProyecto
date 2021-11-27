using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Codigo
    {
        public int IdCodigo { get; set; }
        public string DatoCodigo { get; set; }
        public int CantidadCodigo { get; set; }
        public byte EstadoCodigo { get; set; }
        public int IdSponsor { get; set; }

        public virtual Sponsor IdSponsorNavigation { get; set; }
    }
}
