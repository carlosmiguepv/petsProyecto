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
    public class MascotaRepository : IMascotaRepository
    {
        private readonly PetsContext _context;

        public MascotaRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mascota>> GetMascotas()
        {

            return await _context.Mascota.ToListAsync();

        }

        public async Task<IEnumerable<Mascota>> GetMascotasPerdida()
        {


            return await _context.Mascota.ToListAsync();

        }
        public async Task<Mascota> GetMascotasById(int id)
        {
            return await _context.Mascota.Where(x => x.IdMascota == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Mascota mascota)
        {
            await _context.Mascota.AddAsync(mascota);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Mascota mascota)
        {
            var mascotaNow = await _context.Mascota.FindAsync(mascota.IdMascota);
            mascotaNow.NombreMascota = mascota.NombreMascota;
            mascotaNow.SexoMascota = mascota.SexoMascota;
            mascotaNow.TamañoMascota = mascota.TamañoMascota;
            mascotaNow.EdadMascota = mascota.EdadMascota;
            mascotaNow.IdTipo = mascota.IdTipo;
            mascotaNow.EstadoMascota = mascota.EstadoMascota;
            mascotaNow.FotoMascota = mascota.FotoMascota;
            mascotaNow.IdUsuario = mascota.IdUsuario;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var mascotaNow = await _context.Mascota.FindAsync(id);
            if (mascotaNow == null)
                return false;

            mascotaNow.EstadoMascota = 0;
            //_context.Mascota.Remove(mascotaNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
