using System.Collections.Generic;
using System.Threading.Tasks;
using pets.Domain.Core.Entities;

namespace pets.Domain.Core.Interfaces
{
    public interface ISponsorRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Sponsor>> GetSponsors();
        Task<Sponsor> GetSponsorsById(int id);
        Task Insert(Sponsor sponsor);
        Task<bool> Update(Sponsor sponsor);
    }
}