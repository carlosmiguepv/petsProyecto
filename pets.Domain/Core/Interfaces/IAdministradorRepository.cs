using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface IAdministradorRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Administrador>> GetAdministradores();
        Task<Administrador> GetAdministradoresById(int id);
        Task Insert(Administrador administrador);
        Task<bool> Update(Administrador administrador);
    }
}