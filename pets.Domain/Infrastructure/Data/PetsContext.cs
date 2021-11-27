using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using pets.Domain.Core.Entities;

#nullable disable

namespace pets.Domain.Infrastructure.Data
{
    public partial class PetsContext : DbContext
    {
        public PetsContext()
        {
        }

        public PetsContext(DbContextOptions<PetsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Adoptar> Adoptar { get; set; }
        public virtual DbSet<Codigo> Codigo { get; set; }
        public virtual DbSet<Comentario> Comentario { get; set; }
        public virtual DbSet<Mascota> Mascota { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Publicacion> Publicacion { get; set; }
        public virtual DbSet<Raza> Raza { get; set; }
        public virtual DbSet<Sponsor> Sponsor { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-9Q6APE6P;Database=Pets;User=sa;Pwd=123456789");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.IdAdministrador)
                    .HasName("PK__ADMINIST__134EB62A6046C499");

                entity.ToTable("ADMINISTRADOR");

                entity.Property(e => e.IdAdministrador)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_ADMINISTRADOR");

                entity.Property(e => e.ApellidoAdministrador)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO_ADMINISTRADOR");

                entity.Property(e => e.CelularAdministrador)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CELULAR_ADMINISTRADOR");

                entity.Property(e => e.ContraseñaAdministrador)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASEÑA_ADMINISTRADOR");

                entity.Property(e => e.CorreoAdministrador)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_ADMINISTRADOR");

                entity.Property(e => e.DirecciónUsuario)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCIÓN_USUARIO");

                entity.Property(e => e.EstadoAdministrador).HasColumnName("ESTADO_ADMINISTRADOR");

                entity.Property(e => e.FechaNacimientoAdministrador)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_NACIMIENTO_ADMINISTRADOR");

                entity.Property(e => e.FotoAdministrador)
                    .HasColumnType("image")
                    .HasColumnName("FOTO_ADMINISTRADOR");

                entity.Property(e => e.GeneroAdministrador).HasColumnName("GENERO_ADMINISTRADOR");

                entity.Property(e => e.NombreAdministrador)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_ADMINISTRADOR");
            });

            modelBuilder.Entity<Adoptar>(entity =>
            {
                entity.HasKey(e => e.IdAdoptar)
                    .HasName("PK__ADOPTAR__1FD728CABB88BAEA");

                entity.ToTable("ADOPTAR");

                entity.Property(e => e.IdAdoptar)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_ADOPTAR");

                entity.Property(e => e.DocumentoAdoptar)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTO_ADOPTAR");

                entity.Property(e => e.EstadoAdoptar).HasColumnName("ESTADO_ADOPTAR");

                entity.Property(e => e.IdAdministrador).HasColumnName("ID_ADMINISTRADOR");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdAdministradorNavigation)
                    .WithMany(p => p.Adoptar)
                    .HasForeignKey(d => d.IdAdministrador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ADOPTAR__ID_ADMI__37A5467C");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Adoptar)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ADOPTAR__ID_USUA__38996AB5");
            });

            modelBuilder.Entity<Codigo>(entity =>
            {
                entity.HasKey(e => e.IdCodigo)
                    .HasName("PK__CODIGO__B413839598A576F8");

                entity.ToTable("CODIGO");

                entity.Property(e => e.IdCodigo)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CODIGO");

                entity.Property(e => e.CantidadCodigo).HasColumnName("CANTIDAD_CODIGO");

                entity.Property(e => e.DatoCodigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DATO_CODIGO");

                entity.Property(e => e.EstadoCodigo).HasColumnName("ESTADO_CODIGO");

                entity.Property(e => e.IdSponsor).HasColumnName("ID_SPONSOR");

                entity.HasOne(d => d.IdSponsorNavigation)
                    .WithMany(p => p.Codigo)
                    .HasForeignKey(d => d.IdSponsor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CODIGO__ID_SPONS__398D8EEE");
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.HasKey(e => e.IdComentario)
                    .HasName("PK__COMENTAR__4B0815B15886C514");

                entity.ToTable("COMENTARIO");

                entity.Property(e => e.IdComentario)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_COMENTARIO");

                entity.Property(e => e.DetalleComentario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DETALLE_COMENTARIO");

                entity.Property(e => e.EstadoComentario).HasColumnName("ESTADO_COMENTARIO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Comentario)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COMENTARI__ID_US__3A81B327");
            });

            modelBuilder.Entity<Mascota>(entity =>
            {
                entity.HasKey(e => e.IdMascota)
                    .HasName("PK__MASCOTA__FC5D150DC599F784");

                entity.ToTable("MASCOTA");

                entity.Property(e => e.IdMascota)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_MASCOTA");

                entity.Property(e => e.EdadMascota).HasColumnName("EDAD_MASCOTA");

                entity.Property(e => e.EstadoMascota).HasColumnName("ESTADO_MASCOTA");

                entity.Property(e => e.FotoMascota)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("FOTO_MASCOTA");

                entity.Property(e => e.IdTipo).HasColumnName("ID_TIPO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.NombreMascota)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_MASCOTA");

                entity.Property(e => e.SexoMascota)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("SEXO_MASCOTA");

                entity.Property(e => e.TamañoMascota)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TAMAÑO_MASCOTA");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MASCOTA__ID_TIPO__3B75D760");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MASCOTA__ID_USUA__3C69FB99");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PK__PAIS__B68D33A185588034");

                entity.ToTable("PAIS");

                entity.Property(e => e.IdPais)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PAIS");

                entity.Property(e => e.CodigoPais)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_PAIS")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoPais).HasColumnName("ESTADO_PAIS");

                entity.Property(e => e.NombrePais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_PAIS");
            });

            modelBuilder.Entity<Publicacion>(entity =>
            {
                entity.HasKey(e => e.IdPublicacion)
                    .HasName("PK__PUBLICAC__C7ABD961D56DE578");

                entity.ToTable("PUBLICACION");

                entity.Property(e => e.IdPublicacion)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PUBLICACION");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaPublicacion)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_PUBLICACION");

                entity.Property(e => e.IdAdministrador).HasColumnName("ID_ADMINISTRADOR");

                entity.Property(e => e.IdMascota).HasColumnName("ID_MASCOTA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.MensajePublicacion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MENSAJE_PUBLICACION");

                entity.Property(e => e.NLikesPublicacion).HasColumnName("N_LIKES_PUBLICACION");

                entity.HasOne(d => d.IdAdministradorNavigation)
                    .WithMany(p => p.Publicacion)
                    .HasForeignKey(d => d.IdAdministrador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PUBLICACI__ID_AD__3D5E1FD2");

                entity.HasOne(d => d.IdMascotaNavigation)
                    .WithMany(p => p.Publicacion)
                    .HasForeignKey(d => d.IdMascota)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PUBLICACI__ID_MA__3E52440B");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Publicacion)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PUBLICACI__ID_US__3F466844");
            });

            modelBuilder.Entity<Raza>(entity =>
            {
                entity.HasKey(e => e.IdRaza)
                    .HasName("PK__RAZA__C3517CEE31BA5D4E");

                entity.ToTable("RAZA");

                entity.Property(e => e.IdRaza)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_RAZA");

                entity.Property(e => e.EstadoRaza).HasColumnName("ESTADO_RAZA");

                entity.Property(e => e.NombreRaza)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_RAZA");
            });

            modelBuilder.Entity<Sponsor>(entity =>
            {
                entity.HasKey(e => e.IdSponsor)
                    .HasName("PK__SPONSOR__6680929A277BA868");

                entity.ToTable("SPONSOR");

                entity.Property(e => e.IdSponsor)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_SPONSOR");

                entity.Property(e => e.EstadoSponsor).HasColumnName("ESTADO_SPONSOR");

                entity.Property(e => e.LogoSponsor)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("LOGO_SPONSOR");

                entity.Property(e => e.NombreSponsor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_SPONSOR");

                entity.Property(e => e.UrlSponsor)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("URL_SPONSOR");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__TIPO__DB4DE8ABA7BEE0ED");

                entity.ToTable("TIPO");

                entity.Property(e => e.IdTipo)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_TIPO");

                entity.Property(e => e.EstadoTipo).HasColumnName("ESTADO_TIPO");

                entity.Property(e => e.IdRaza).HasColumnName("ID_RAZA");

                entity.Property(e => e.NombreTipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_TIPO");

                entity.HasOne(d => d.IdRazaNavigation)
                    .WithMany(p => p.Tipo)
                    .HasForeignKey(d => d.IdRaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TIPO__ID_RAZA__403A8C7D");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIO__91136B90260B6C14");

                entity.ToTable("USUARIO");

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_USUARIO");

                entity.Property(e => e.ApellidoUsuario)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO_USUARIO");

                entity.Property(e => e.CelularUsuario)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CELULAR_USUARIO");

                entity.Property(e => e.ContraseñaUsuario)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASEÑA_USUARIO");

                entity.Property(e => e.CorreoUsuario)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_USUARIO");

                entity.Property(e => e.DirecciónUsuario)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCIÓN_USUARIO");

                entity.Property(e => e.EstadoUsuario).HasColumnName("ESTADO_USUARIO");

                entity.Property(e => e.FechaNacimientoUsuario)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_NACIMIENTO_USUARIO");

                entity.Property(e => e.FotoUsuario)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("FOTO_USUARIO");

                entity.Property(e => e.GeneroUsuario).HasColumnName("GENERO_USUARIO");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_USUARIO");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIO__ID_PAIS__412EB0B6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
