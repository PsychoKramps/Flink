using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Flink.Infraestructure.Persistance
{
    public partial class FlinkContext : DbContext
    {
        public FlinkContext()
        {
        }

        public FlinkContext(DbContextOptions<FlinkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Curso> Cursos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuarioCurso> UsuarioCursos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Curso__06370DADDBF088D6");

                entity.ToTable("Curso");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.NombreCurso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCurso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlCurso).IsUnicode(false);
            });

        

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97EF70E641");

                entity.ToTable("Usuario");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuarioCurso>(entity =>
            {
                entity.ToTable("UsuarioCurso");

                entity.HasOne(d => d.CodigoCursoNavigation)
                    .WithMany(p => p.UsuarioCursos)
                    .HasForeignKey(d => d.CodigoCurso)
                    .HasConstraintName("FK__UsuarioCu__Codig__3B75D760");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioCursos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__UsuarioCu__IdUsu__3A81B327");
            });
            _ = modelBuilder.Entity<Usuario>().HasData(
    new Usuario { IdUsuario = 1, Nombre1 = "Fraiden", Apellido1 = "Restrepo", Correo = "fraiden@Gmail.com", NombreUsuario = "LOL", Contraseña = "123456" },
    new Usuario { IdUsuario = 2, Nombre1 = "Chirs", Apellido1 = "lol", Correo = "cris@Gmail.com", NombreUsuario = "im", Contraseña = "1234567855" },
    new Usuario { IdUsuario = 3, Nombre1 = "Andres", Apellido1 = "Venites", Correo = "Holi@Gmail.com", NombreUsuario = "elmatalocos", Contraseña = "1414" },
    new Usuario { IdUsuario = 4, Nombre1 = "lolito", Apellido1 = "nedaños", Correo = "nada@Gmail.com", NombreUsuario = "LOL", Contraseña = "1313131" }
    );


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
