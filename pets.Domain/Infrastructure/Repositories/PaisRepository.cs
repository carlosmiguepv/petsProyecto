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
    public class PaisRepository : IPaisRepository
    {
        private readonly PetsContext _context;

        public PaisRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pais>> GetPaises()
        {
            //using var data = new SalesContext();
            return await _context.Pais.ToListAsync();

        }
        public async Task<Pais> GetPaisesById(int id)
        {
            return await _context.Pais.Where(x => x.IdPais == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Pais pais)
        {
            await _context.Pais.AddAsync(pais);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Pais pais)
        {
            var paisNow = await _context.Pais.FindAsync(pais.IdPais);
            paisNow.NombrePais = pais.NombrePais;
            paisNow.CodigoPais = pais.CodigoPais;
            paisNow.EstadoPais = pais.EstadoPais;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var paisNow = await _context.Pais.FindAsync(id);
            if (paisNow == null)
                return false;

            paisNow.EstadoPais = 0;
            //_context.Publicacion.Remove(paisNow);
            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
