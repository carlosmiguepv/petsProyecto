using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class AdministradorDTO
    {
        public int IdAdministrador { get; set; }
        public string NombreAdministrador { get; set; }
        public string ApellidoAdministrador { get; set; }
        public string CelularAdministrador { get; set; }
        public string DirecciónUsuario { get; set; }
        public DateTime? FechaNacimientoAdministrador { get; set; }
        public string CorreoAdministrador { get; set; }
        public string ContraseñaAdministrador { get; set; }
        public bool? GeneroAdministrador { get; set; }
        public byte[] FotoAdministrador { get; set; }
        public int EstadoAdministrador { get; set; }
    }

    public class AdministradorPostDTO
    {
        public string NombreAdministrador { get; set; }
        public string ApellidoAdministrador { get; set; }
        public string CelularAdministrador { get; set; }
        public string DirecciónUsuario { get; set; }
        public string CorreoAdministrador { get; set; }
        public string ContraseñaAdministrador { get; set; }
        public bool? GeneroAdministrador { get; set; }
        public byte[] FotoAdministrador { get; set; }
        public int EstadoAdministrador { get; set; }
    }
}
