using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class MascotaDTO
    {
        public int IdMascota { get; set; }
        public string NombreMascota { get; set; }
        public string SexoMascota { get; set; }
        public string TamañoMascota { get; set; }
        public byte EdadMascota { get; set; }
        public int IdTipo { get; set; }
        public int EstadoMascota { get; set; }
        public string FotoMascota { get; set; }
        public int IdUsuario { get; set; }
    }

    public class MascotaPostDTO
    {
        public int IdMascota { get; set; }
        public string NombreMascota { get; set; }
        public string SexoMascota { get; set; }
        public string TamañoMascota { get; set; }
        public byte EdadMascota { get; set; }
        public int IdTipo { get; set; }
        public int EstadoMascota { get; set; }
        public string FotoMascota { get; set; }
    }
    public class Mascota_id
    {
        public string NombreMascota { get; set; }
        public string SexoMascota { get; set; }
        public string TamañoMascota { get; set; }
        public byte EdadMascota { get; set; }
        public int IdTipo { get; set; }
        public int EstadoMascota { get; set; }
        public string FotoMascota { get; set; }
        public int IdUsuario { get; set; }
    }

    
}
