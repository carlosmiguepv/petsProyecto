using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class SponsorDTO
    {
        public int IdSponsor { get; set; }
        public string NombreSponsor { get; set; }
        public string UrlSponsor { get; set; }
        public string LogoSponsor { get; set; }
        public int EstadoSponsor { get; set; }
    }

    public class SponsorPostDTO
    {
        public string NombreSponsor { get; set; }
        public string UrlSponsor { get; set; }
        public string LogoSponsor { get; set; }
        public int EstadoSponsor { get; set; }
    }

    public class Sponsor_Lo_URL
    {
        public string UrlSponsor { get; set; }
        public string LogoSponsor { get; set; }
    }

}
