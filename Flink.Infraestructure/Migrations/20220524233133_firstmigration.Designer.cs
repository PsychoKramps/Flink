﻿// <auto-generated />
using System;
using Flink.Infraestructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Flink.Infraestructure.Migrations
{
    [DbContext(typeof(FlinkContext))]
    [Migration("20220524233133_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Flink.Infraestructure.Persistance.Curso", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<string>("Categoria")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<TimeSpan>("Duracion")
                        .HasColumnType("time");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha");

                    b.Property<string>("NombreCurso")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TipoCurso")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UrlCurso")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Codigo")
                        .HasName("PK__Curso__06370DADDBF088D6");

                    b.ToTable("Curso", (string)null);
                });

            modelBuilder.Entity("Flink.Infraestructure.Persistance.TblUsuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("Id_usuario");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdUsuario")
                        .HasName("PK__TblUsuar__EF59F76215E66D5E");

                    b.ToTable("TblUsuario", (string)null);
                });

            modelBuilder.Entity("Flink.Infraestructure.Persistance.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Apellido2")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("contraseña");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre1")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nombre2")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__5B65BF97EF70E641");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Flink.Infraestructure.Persistance.UsuarioCurso", b =>
                {
                    b.Property<int>("UsuarioCursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioCursoId"), 1L, 1);

                    b.Property<int?>("CodigoCurso")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("UsuarioCursoId");

                    b.HasIndex("CodigoCurso");

                    b.HasIndex("IdUsuario");

                    b.ToTable("UsuarioCurso", (string)null);
                });

            modelBuilder.Entity("Flink.Infraestructure.Persistance.UsuarioCurso", b =>
                {
                    b.HasOne("Flink.Infraestructure.Persistance.Curso", "CodigoCursoNavigation")
                        .WithMany("UsuarioCursos")
                        .HasForeignKey("CodigoCurso")
                        .HasConstraintName("FK__UsuarioCu__Codig__3B75D760");

                    b.HasOne("Flink.Infraestructure.Persistance.Usuario", "IdUsuarioNavigation")
                        .WithMany("UsuarioCursos")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__UsuarioCu__IdUsu__3A81B327");

                    b.Navigation("CodigoCursoNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("Flink.Infraestructure.Persistance.Curso", b =>
                {
                    b.Navigation("UsuarioCursos");
                });

            modelBuilder.Entity("Flink.Infraestructure.Persistance.Usuario", b =>
                {
                    b.Navigation("UsuarioCursos");
                });
#pragma warning restore 612, 618
        }
    }
}