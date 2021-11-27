using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface IPublicacionRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Publicacion>> GetPublicaciones();
        Task<Publicacion> GetPublicacionesById(int id);
        Task Insert(Publicacion publicacion);
        Task<bool> Update(Publicacion publicacion);
    }
}