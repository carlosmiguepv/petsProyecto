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
    public class TipoRepository : ITipoRepository
    {
        private readonly PetsContext _context;

        public TipoRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tipo>> GetTipos()
        {
            //using var data = new SalesContext();
            return await _context.Tipo.ToListAsync();

        }
        public async Task<Tipo> GetTiposById(int id)
        {
            return await _context.Tipo.Where(x => x.IdTipo == id).FirstOrDefaultAsync();
        }

        //Insertar
        public async Task Insert(Tipo tipo)
        {
            await _context.Tipo.AddAsync(tipo);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Tipo tipo)
        {
            var tipoNow = await _context.Tipo.FindAsync(tipo.IdTipo);
            tipoNow.IdRaza = tipo.IdRaza;
            tipoNow.NombreTipo = tipo.NombreTipo;
            tipoNow.EstadoTipo = tipo.EstadoTipo;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var tipoNow = await _context.Tipo.FindAsync(id);
            if (tipoNow == null)
                return false;

            tipoNow.EstadoTipo = 0;
            //_context.Tipo.Remove(tipoNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
