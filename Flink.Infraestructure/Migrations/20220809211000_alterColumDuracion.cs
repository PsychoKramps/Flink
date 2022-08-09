using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flink.Infraestructure.Migrations
{
    public partial class alterColumDuracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Duracion",
                table: "Curso",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 1,
                columns: new[] { "Duracion", "fecha" },
                values: new object[] { "10:45:78", new DateTime(2022, 8, 9, 16, 9, 59, 959, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 2,
                columns: new[] { "Duracion", "fecha" },
                values: new object[] { "8:45:14", new DateTime(2022, 8, 9, 16, 9, 59, 959, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 3,
                columns: new[] { "Duracion", "fecha" },
                values: new object[] { "09:12:83", new DateTime(2022, 8, 9, 16, 9, 59, 959, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 4,
                columns: new[] { "Duracion", "fecha" },
                values: new object[] { "12:23:12", new DateTime(2022, 8, 9, 16, 9, 59, 959, DateTimeKind.Local).AddTicks(3512) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duracion",
                table: "Curso",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 1,
                columns: new[] { "Duracion", "fecha" },
                values: new object[] { new TimeSpan(0, 10, 0, 40, 0), new DateTime(2022, 8, 8, 16, 38, 6, 49, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 2,
                columns: new[] { "Duracion", "fecha" },
                values: new object[] { new TimeSpan(0, 9, 8, 40, 0), new DateTime(2022, 8, 8, 16, 38, 6, 49, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 3,
                columns: new[] { "Duracion", "fecha" },
                values: new object[] { new TimeSpan(0, 7, 29, 40, 0), new DateTime(2022, 8, 8, 16, 38, 6, 49, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 4,
                columns: new[] { "Duracion", "fecha" },
                values: new object[] { new TimeSpan(0, 6, 29, 40, 0), new DateTime(2022, 8, 8, 16, 38, 6, 49, DateTimeKind.Local).AddTicks(9413) });
        }
    }
}
