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
    public class PublicacionRepository : IPublicacionRepository
    {
        private readonly PetsContext _context;

        public PublicacionRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Publicacion>> GetPublicaciones()
        {
            //using var data = new SalesContext();
            return await _context.Publicacion.ToListAsync();

        }
        public async Task<Publicacion> GetPublicacionesById(int id)
        {
            return await _context.Publicacion.Where(x => x.IdPublicacion == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Publicacion publicacion)
        {
            await _context.Publicacion.AddAsync(publicacion);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Publicacion publicacion)
        {
            var publicacionNow = await _context.Publicacion.FindAsync(publicacion.IdPublicacion);
            publicacionNow.IdAdministrador = publicacion.IdAdministrador;
            publicacionNow.IdUsuario = publicacion.IdUsuario;
            publicacionNow.IdMascota = publicacion.IdMascota;
            publicacionNow.MensajePublicacion = publicacion.MensajePublicacion;
            publicacionNow.NLikesPublicacion = publicacion.NLikesPublicacion;
            publicacionNow.FechaPublicacion = publicacion.FechaPublicacion;
            publicacionNow.Estado = publicacion.Estado;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var publicacionNow = await _context.Publicacion.FindAsync(id);
            if (publicacionNow == null)
                return false;

            publicacionNow.Estado = 0;
            //_context.Publicacion.Remove(publicacionNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
