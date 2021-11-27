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
    public class AdministradorRepository : IAdministradorRepository
    {
        private readonly PetsContext _context;

        public AdministradorRepository(PetsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Administrador>> GetAdministradores()
        {
            //using var data = new SalesContext();
            return await _context.Administrador.ToListAsync();

        }
        public async Task<Administrador> GetAdministradoresById(int id)
        {
            return await _context.Administrador.Where(x => x.IdAdministrador == id).FirstOrDefaultAsync();

        }

        //Insertar
        public async Task Insert(Administrador administrador)
        {
            await _context.Administrador.AddAsync(administrador);
            await _context.SaveChangesAsync();
        }

        //Actualizar
        public async Task<bool> Update(Administrador administrador)
        {
            var administradorNow = await _context.Administrador.FindAsync(administrador.IdAdministrador);
            administradorNow.NombreAdministrador = administrador.NombreAdministrador;
            administradorNow.ApellidoAdministrador = administrador.ApellidoAdministrador;
            administradorNow.CelularAdministrador = administrador.CelularAdministrador;
            administradorNow.DirecciónUsuario = administrador.DirecciónUsuario;
            administradorNow.FechaNacimientoAdministrador = administrador.FechaNacimientoAdministrador;
            administradorNow.CorreoAdministrador = administrador.CorreoAdministrador;
            administradorNow.ContraseñaAdministrador = administrador.ContraseñaAdministrador;
            administradorNow.GeneroAdministrador = administrador.GeneroAdministrador;
            administradorNow.FotoAdministrador = administrador.FotoAdministrador;
            administradorNow.EstadoAdministrador = administrador.EstadoAdministrador;

            int countRow = await _context.SaveChangesAsync();
            return (countRow > 0);
        }

        //Eliminar
        public async Task<bool> Delete(int id)
        {
            var administradorNow = await _context.Administrador.FindAsync(id);
            if (administradorNow == null)
                return false;

            administradorNow.EstadoAdministrador = 0;
            //_context.Administrador.Remove(administradorNow);

            int coutRows = await _context.SaveChangesAsync();
            return (coutRows > 0);
        }
    }
}
