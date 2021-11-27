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
    public class RazaRepository : IRazaRepository
    {
        private readonly PetsContext _context;

        public RazaRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Raza>> GetRazas()
        {
            //using var data = new SalesContext();
            return await _context.Raza.ToListAsync();

        }
        public async Task<Raza> GetRazasById(int id)
        {
            return await _context.Raza.Where(x => x.IdRaza == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Raza raza)
        {
            await _context.Raza.AddAsync(raza);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Raza raza)
        {
            var razaNow = await _context.Raza.FindAsync(raza.IdRaza);
            razaNow.NombreRaza = raza.NombreRaza;
            razaNow.EstadoRaza = raza.EstadoRaza;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var razaNow = await _context.Raza.FindAsync(id);
            if (razaNow == null)
                return false;

            razaNow.EstadoRaza = 0;
            //_context.Raza.Remove(razaNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
