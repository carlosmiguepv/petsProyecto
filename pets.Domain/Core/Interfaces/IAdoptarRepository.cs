using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface IAdoptarRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Adoptar>> GetAdoptars();
        Task<Adoptar> GetAdoptarsById(int id);
        Task Insert(Adoptar adoptar);
        Task<bool> Update(Adoptar adoptar);
    }
}