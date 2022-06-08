using Flink.Application;
using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Filters;
using Flink.Infraestructure.Persistance;
using Flink.Infraestructure.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers(
    options =>
    {
        //Se registra el manejo de excepciones de forma global
        options.Filters.Add<GlobalExceptionFilter>();
    })
.AddFluentValidation();

builder.Services.AddApplicationServices();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FlinkContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Flink")));

//registrar dependendencias
builder.Services.AddTransient<IUsuarioRepository,UsuarioRepository>();
builder.Services.AddTransient<ICursoRepository, CursoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
