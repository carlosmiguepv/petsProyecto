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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PetsContext _context;

        public UsuarioRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            //using var data = new SalesContext();
            return await _context.Usuario.ToListAsync();

        }
        public async Task<Usuario> GetUsuariosById(int id)
        {
            return await _context.Usuario.Where(x => x.IdUsuario == id).FirstOrDefaultAsync();
        }

        //Insertar
        public async Task Insert(Usuario usuario)
        {
            await _context.Usuario.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Usuario usuario)
        {
            var usuarioNow = await _context.Usuario.FindAsync(usuario.IdUsuario);
            usuarioNow.NombreUsuario = usuario.NombreUsuario;
            usuarioNow.ApellidoUsuario = usuario.ApellidoUsuario;
            usuarioNow.CelularUsuario = usuario.CelularUsuario;
            usuarioNow.DirecciónUsuario = usuario.DirecciónUsuario;
            usuarioNow.IdPais = usuario.IdPais;
            usuarioNow.FechaNacimientoUsuario = usuario.FechaNacimientoUsuario;
            usuarioNow.CorreoUsuario = usuario.CorreoUsuario;
            usuarioNow.ContraseñaUsuario = usuario.ContraseñaUsuario;
            usuarioNow.GeneroUsuario = usuario.GeneroUsuario;
            usuarioNow.FotoUsuario = usuario.FotoUsuario;
            usuarioNow.EstadoUsuario = usuario.EstadoUsuario;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var usuarioNow = await _context.Usuario.FindAsync(id);
            if (usuarioNow == null)
                return false;

            usuarioNow.EstadoUsuario = 0;
            //_context.Usuario.Remove(usuarioNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
