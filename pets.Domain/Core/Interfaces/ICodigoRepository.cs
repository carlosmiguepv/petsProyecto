using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface ICodigoRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Codigo>> GetCodigos();
        Task<Codigo> GetCodigosById(int id);
        Task Insert(Codigo codigo);
        Task<bool> Update(Codigo codigo);
    }
}