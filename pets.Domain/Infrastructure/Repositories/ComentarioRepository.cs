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
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly PetsContext _context;

        public ComentarioRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Comentario>> GetComentarios()
        {
            //using var data = new SalesContext();
            return await _context.Comentario.ToListAsync();

        }
        public async Task<Comentario> GetComentariosById(int id)
        {
            return await _context.Comentario.Where(x => x.IdComentario == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Comentario comentario)
        {
            await _context.Comentario.AddAsync(comentario);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Comentario comentario)
        {
            var comentarioNow = await _context.Comentario.FindAsync(comentario.IdComentario);
            comentarioNow.IdUsuario = comentario.IdUsuario;
            comentarioNow.DetalleComentario = comentario.DetalleComentario;
            comentarioNow.EstadoComentario = comentario.EstadoComentario;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var comentarioNow = await _context.Comentario.FindAsync(id);
            if (comentarioNow == null)
                return false;

            comentarioNow.EstadoComentario = 0;
            //_context.Comentario.Remove(comentarioNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
