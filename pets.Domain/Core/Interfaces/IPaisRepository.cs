using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface IPaisRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Pais>> GetPaises();
        Task<Pais> GetPaisesById(int id);
        Task Insert(Pais pais);
        Task<bool> Update(Pais pais);
    }
}