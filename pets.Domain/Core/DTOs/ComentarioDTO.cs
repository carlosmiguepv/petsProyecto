using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets.Domain.Core.DTOs
{
    public class ComentarioDTO
    {
        public int IdComentario { get; set; }
        public int IdUsuario { get; set; }
        public string DetalleComentario { get; set; }
        public int EstadoComentario { get; set; }
    }

    public class ComentarioPostDTO
    {
        public int IdUsuario { get; set; }
        public string DetalleComentario { get; set; }
    }
}
