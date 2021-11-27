using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Sponsor
    {
        public Sponsor()
        {
            Codigo = new HashSet<Codigo>();
        }

        public int IdSponsor { get; set; }
        public string NombreSponsor { get; set; }
        public string UrlSponsor { get; set; }
        public string LogoSponsor { get; set; }
        public int EstadoSponsor { get; set; }

        public virtual ICollection<Codigo> Codigo { get; set; }
    }
}
