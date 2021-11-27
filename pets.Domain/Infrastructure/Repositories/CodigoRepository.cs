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
    public class CodigoRepository : ICodigoRepository
    {
        private readonly PetsContext _context;

        public CodigoRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Codigo>> GetCodigos()
        {
            //using var data = new SalesContext();
            return await _context.Codigo.ToListAsync();

        }
        public async Task<Codigo> GetCodigosById(int id)
        {
            return await _context.Codigo.Where(x => x.IdCodigo == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Codigo codigo)
        {
            await _context.Codigo.AddAsync(codigo);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Codigo codigo)
        {
            var codigoNow = await _context.Codigo.FindAsync(codigo.IdCodigo);
            codigoNow.DatoCodigo = codigo.DatoCodigo;
            codigoNow.CantidadCodigo = codigo.CantidadCodigo;
            codigoNow.EstadoCodigo = codigo.EstadoCodigo;
            codigoNow.IdSponsor = codigo.IdSponsor;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var codigoNow = await _context.Codigo.FindAsync(id);
            if (codigoNow == null)
                return false;

            codigoNow.EstadoCodigo = 0;
            //_context.Mascota.Remove(mascotaNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
