using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface ITipoRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Tipo>> GetTipos();
        Task<Tipo> GetTiposById(int id);
        Task Insert(Tipo tipo);
        Task<bool> Update(Tipo tipo);
    }
}