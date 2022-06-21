using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flink.Infraestructure.Migrations
{
    public partial class NuevaTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginUsuario",
                columns: table => new
                {
                    IdAdmin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Activo = table.Column<bool>(type: "bit", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoginUsuario__", x => x.IdAdmin);
                });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 1,
                column: "fecha",
                value: new DateTime(2022, 6, 20, 22, 56, 31, 847, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 2,
                column: "fecha",
                value: new DateTime(2022, 6, 20, 22, 56, 31, 847, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 3,
                column: "fecha",
                value: new DateTime(2022, 6, 20, 22, 56, 31, 847, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 4,
                column: "fecha",
                value: new DateTime(2022, 6, 20, 22, 56, 31, 847, DateTimeKind.Local).AddTicks(8367));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginUsuario");

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 1,
                column: "fecha",
                value: new DateTime(2022, 5, 26, 21, 48, 52, 278, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 2,
                column: "fecha",
                value: new DateTime(2022, 5, 26, 21, 48, 52, 278, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 3,
                column: "fecha",
                value: new DateTime(2022, 5, 26, 21, 48, 52, 278, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 4,
                column: "fecha",
                value: new DateTime(2022, 5, 26, 21, 48, 52, 278, DateTimeKind.Local).AddTicks(1243));
        }
    }
}
