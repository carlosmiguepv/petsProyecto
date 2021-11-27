using System;
using System.Collections.Generic;

#nullable disable

namespace pets.Domain.Core.Entities
{
    public partial class Comentario
    {
        public int IdComentario { get; set; }
        public int IdUsuario { get; set; }
        public string DetalleComentario { get; set; }
        public int EstadoComentario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
