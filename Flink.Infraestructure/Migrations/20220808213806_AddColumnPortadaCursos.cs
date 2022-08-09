using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flink.Infraestructure.Migrations
{
    public partial class AddColumnPortadaCursos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Portada",
                table: "Curso",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 1,
                columns: new[] { "fecha", "Portada" },
                values: new object[] { new DateTime(2022, 8, 8, 16, 38, 6, 49, DateTimeKind.Local).AddTicks(9398), "https://i.ytimg.com/vi/RqQ1d1qEWlE/maxresdefault.jpg" });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 2,
                columns: new[] { "fecha", "Portada" },
                values: new object[] { new DateTime(2022, 8, 8, 16, 38, 6, 49, DateTimeKind.Local).AddTicks(9410), "https://assets2-programarya-com.juandmegon.com/img/Cursos/Python/Python-header.png" });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 3,
                columns: new[] { "fecha", "Portada" },
                values: new object[] { new DateTime(2022, 8, 8, 16, 38, 6, 49, DateTimeKind.Local).AddTicks(9411), "https://i0.wp.com/unaaldia.hispasec.com/wp-content/uploads/2019/09/Captura-de-pantalla-de-2019-09-07-04-06-35.png?fit=983%2C633&ssl=1" });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 4,
                columns: new[] { "fecha", "Portada" },
                values: new object[] { new DateTime(2022, 8, 8, 16, 38, 6, 49, DateTimeKind.Local).AddTicks(9413), "https://cdn.fs.teachablecdn.com/f0o2YGKTFONup7nJc8aQ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Portada",
                table: "Curso");

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 1,
                column: "fecha",
                value: new DateTime(2022, 8, 8, 13, 6, 37, 801, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 2,
                column: "fecha",
                value: new DateTime(2022, 8, 8, 13, 6, 37, 801, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 3,
                column: "fecha",
                value: new DateTime(2022, 8, 8, 13, 6, 37, 801, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 4,
                column: "fecha",
                value: new DateTime(2022, 8, 8, 13, 6, 37, 801, DateTimeKind.Local).AddTicks(3417));
        }
    }
}
