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
    public class AdoptarRepository : IAdoptarRepository
    {
        private readonly PetsContext _context;

        public AdoptarRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Adoptar>> GetAdoptars()
        {
            //using var data = new SalesContext();
            return await _context.Adoptar.ToListAsync();

        }
        public async Task<Adoptar> GetAdoptarsById(int id)
        {
            return await _context.Adoptar.Where(x => x.IdAdoptar == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Adoptar adoptar)
        {
            await _context.Adoptar.AddAsync(adoptar);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Adoptar adoptar)
        {
            var adoptarNow = await _context.Adoptar.FindAsync(adoptar.IdAdoptar);
            adoptarNow.IdAdministrador = adoptar.IdAdministrador;
            adoptarNow.IdUsuario = adoptar.IdUsuario;
            adoptarNow.DocumentoAdoptar = adoptar.DocumentoAdoptar;
            adoptarNow.EstadoAdoptar = adoptar.EstadoAdoptar;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var adoptarNow = await _context.Adoptar.FindAsync(id);
            if (adoptarNow == null)
                return false;

            adoptarNow.EstadoAdoptar = 0;
            //_context.Adoptar.Remove(adoptarNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
