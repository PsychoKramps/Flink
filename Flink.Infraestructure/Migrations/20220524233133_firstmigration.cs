using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flink.Infraestructure.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCurso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UrlCurso = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Duracion = table.Column<TimeSpan>(type: "time", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    TipoCurso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Categoria = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Curso__06370DADDBF088D6", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "TblUsuario",
                columns: table => new
                {
                    Id_usuario = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NombreUsuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Contraseña = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TblUsuar__EF59F76215E66D5E", x => x.Id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Nombre2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Apellido1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Apellido2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NombreUsuario = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    contraseña = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuario__5B65BF97EF70E641", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioCurso",
                columns: table => new
                {
                    UsuarioCursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    CodigoCurso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioCurso", x => x.UsuarioCursoId);
                    table.ForeignKey(
                        name: "FK__UsuarioCu__Codig__3B75D760",
                        column: x => x.CodigoCurso,
                        principalTable: "Curso",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "FK__UsuarioCu__IdUsu__3A81B327",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioCurso_CodigoCurso",
                table: "UsuarioCurso",
                column: "CodigoCurso");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioCurso_IdUsuario",
                table: "UsuarioCurso",
                column: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblUsuario");

            migrationBuilder.DropTable(
                name: "UsuarioCurso");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
