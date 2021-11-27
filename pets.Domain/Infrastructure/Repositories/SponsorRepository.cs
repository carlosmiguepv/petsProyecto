using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pets.Domain.Core.Entities;
using pets.Domain.Core.Interfaces;
using pets.Domain.Infrastructure.Data;

namespace pets.Domain.Infrastructure.Repositories
{
    public class SponsorRepository : ISponsorRepository
    {
        private readonly PetsContext _context;

        public SponsorRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sponsor>> GetSponsors()
        {
            //using var data = new SalesContext();
            return await _context.Sponsor.ToListAsync();

        }
        public async Task<Sponsor> GetSponsorsById(int id)
        {
            return await _context.Sponsor.Where(x => x.IdSponsor == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Sponsor sponsor)
        {
            await _context.Sponsor.AddAsync(sponsor);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Sponsor sponsor)
        {
            var sponsorNow = await _context.Sponsor.FindAsync(sponsor.IdSponsor);
            sponsorNow.NombreSponsor = sponsor.NombreSponsor;
            sponsorNow.UrlSponsor = sponsor.UrlSponsor;
            sponsorNow.LogoSponsor = sponsor.LogoSponsor;
            sponsorNow.EstadoSponsor = sponsor.EstadoSponsor;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var sponsorNow = await _context.Sponsor.FindAsync(id);
            if (sponsorNow == null)
                return false;

            sponsorNow.EstadoSponsor = 0;
            //_context.Sponsor.Remove(sponsorNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
