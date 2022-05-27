using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flink.Infraestructure.Migrations
{
    public partial class AlterTableCurses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Codigo", "Categoria", "Descripcion", "Duracion", "fecha", "NombreCurso", "TipoCurso", "UrlCurso" },
                values: new object[,]
                {
                    { 1, "Desarrollo de software", "Conoce los conceptos clave del lenguaje de programación que se está comiendo al mundo. Aprende qué es una variable, una función, un objeto y dónde se guardan esos valores. Descubre qué es Scope y cómo se utilizan los loops.", new TimeSpan(0, 10, 0, 40, 0), new DateTime(2022, 5, 26, 21, 48, 52, 278, DateTimeKind.Local).AddTicks(1230), "Curso de JavaScript", "Programacion", "https://www.youtube.com/watch?v=z95mZVUcJ-E" },
                    { 2, "Desarrollo de software", "Aprende Python 3 como un profesional empezando por las bases hasta programar tus propios algoritmos o juegos completos", new TimeSpan(0, 9, 8, 40, 0), new DateTime(2022, 5, 26, 21, 48, 52, 278, DateTimeKind.Local).AddTicks(1240), "Curso de Python", "Programacion", "https://www.youtube.com/watch?v=swdcD6OPMlk" },
                    { 3, "Desarrollo de software", "¡Aprende PHP, el lenguaje de programación para backend presente en el 80% de sitios web! Inicia tu ruta de aprendizaje como PHP Developer y desarrolla tus primeros algoritmos con tu profesor Retax Master.", new TimeSpan(0, 7, 29, 40, 0), new DateTime(2022, 5, 26, 21, 48, 52, 278, DateTimeKind.Local).AddTicks(1242), "Curso de PHP", "Programacion", "https://www.youtube.com/watch?v=nCB1gEkRZ1g" },
                    { 4, "Desarrollo de software", "Avanza tu camino en el mundo de la programación con C#, uno de los lenguajes más utilizados en desarrollo web y videojuegos, con tu profesor Ricardo Celis.", new TimeSpan(0, 6, 29, 40, 0), new DateTime(2022, 5, 26, 21, 48, 52, 278, DateTimeKind.Local).AddTicks(1243), "Curso de C#", "Programacion", "https://www.youtube.com/watch?v=TqiysLEBZo4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "Codigo",
                keyValue: 4);
        }
    }
}
