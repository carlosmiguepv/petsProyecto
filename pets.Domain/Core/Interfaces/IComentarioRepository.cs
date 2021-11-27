using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface IComentarioRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Comentario>> GetComentarios();
        Task<Comentario> GetComentariosById(int id);
        Task Insert(Comentario comentario);
        Task<bool> Update(Comentario comentario);
    }
}