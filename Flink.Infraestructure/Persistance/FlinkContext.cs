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
        public virtual DbSet<Usuario> Usuario { get; set; } = null!;
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

            modelBuilder.Entity<UsuarioCurso>((Action<Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UsuarioCurso>>)(entity =>
            {
                entity.ToTable<UsuarioCurso>("UsuarioCurso");

                entity.HasOne<Curso>(d => d.Codigo)
                    .WithMany(p => p.UsuarioCursos)
                    .HasForeignKey(d => d.CodigoCurso)
                    .HasConstraintName<Curso, UsuarioCurso>("FK__UsuarioCu__Codig__3B75D760");

                entity.HasOne<Usuario>(d => (Usuario?)d.IdUsuario)
                    .WithMany(p => p.UsuarioCursos)
                    .HasForeignKey((System.Linq.Expressions.Expression<Func<UsuarioCurso, object?>>)(d => (object?)d.IdUsuario))
                    .HasConstraintName<Usuario, UsuarioCurso>("FK__UsuarioCu__IdUsu__3A81B327");
            }));

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { IdUsuario = 1, Nombre1 = "Fraiden", Apellido1 = "Restrepo", Correo = "fraiden@Gmail.com", NombreUsuario = "LOL", Contraseña = "123456" },
                new Usuario { IdUsuario = 2, Nombre1 = "Chirs", Apellido1 = "lol", Correo = "cris@Gmail.com", NombreUsuario = "im", Contraseña = "1234567855" },
                new Usuario { IdUsuario = 3, Nombre1 = "Andres", Apellido1 = "Venites", Correo = "Holi@Gmail.com", NombreUsuario = "elmatalocos", Contraseña = "1414" },
                new Usuario { IdUsuario = 4, Nombre1 = "lolito", Apellido1 = "nedaños", Correo = "nada@Gmail.com", NombreUsuario = "LOL", Contraseña = "1313131" }
                );

            modelBuilder.Entity<Curso>().HasData(
                new Curso { Codigo = 1, NombreCurso = "Curso de JavaScript", UrlCurso = "https://www.youtube.com/watch?v=z95mZVUcJ-E", Fecha = DateTime.Now, Duracion = new TimeSpan(10, 00, 40), Descripcion = "Conoce los conceptos clave del lenguaje de programación que se está comiendo al mundo. Aprende qué es una variable, una función, un objeto y dónde se guardan esos valores. Descubre qué es Scope y cómo se utilizan los loops.", TipoCurso = "Programacion", Categoria = "Desarrollo de software" },
                new Curso { Codigo = 2, NombreCurso = "Curso de Python", UrlCurso = "https://www.youtube.com/watch?v=swdcD6OPMlk", Fecha = DateTime.Now, Duracion = new TimeSpan(9, 08, 40), Descripcion = "Aprende Python 3 como un profesional empezando por las bases hasta programar tus propios algoritmos o juegos completos", TipoCurso = "Programacion", Categoria = "Desarrollo de software" },
                new Curso { Codigo = 3, NombreCurso = "Curso de PHP", UrlCurso = "https://www.youtube.com/watch?v=nCB1gEkRZ1g", Fecha = DateTime.Now, Duracion = new TimeSpan(7, 29, 40), Descripcion = "¡Aprende PHP, el lenguaje de programación para backend presente en el 80% de sitios web! Inicia tu ruta de aprendizaje como PHP Developer y desarrolla tus primeros algoritmos con tu profesor Retax Master.", TipoCurso = "Programacion", Categoria = "Desarrollo de software" },
                new Curso { Codigo = 4, NombreCurso = "Curso de C#", UrlCurso = "https://www.youtube.com/watch?v=TqiysLEBZo4", Fecha = DateTime.Now, Duracion = new TimeSpan(6, 29, 40), Descripcion = "Avanza tu camino en el mundo de la programación con C#, uno de los lenguajes más utilizados en desarrollo web y videojuegos, con tu profesor Ricardo Celis.", TipoCurso = "Programacion", Categoria = "Desarrollo de software" }
                );


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
