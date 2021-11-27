using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface IMascotaRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Mascota>> GetMascotas();
        Task<Mascota> GetMascotasById(int id);
        Task Insert(Mascota mascota);
        Task<bool> Update(Mascota mascota);
    }
}