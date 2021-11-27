using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface IRazaRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Raza>> GetRazas();
        Task<Raza> GetRazasById(int id);
        Task Insert(Raza raza);
        Task<bool> Update(Raza raza);
    }
}