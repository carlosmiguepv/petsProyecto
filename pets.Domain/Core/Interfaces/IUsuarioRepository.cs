using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuariosById(int id);
        Task Insert(Usuario usuario);
        Task<bool> Update(Usuario usuario);
    }
}