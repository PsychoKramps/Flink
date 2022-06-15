using Flink.Application;
using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Filters;
using Flink.Infraestructure.Persistance;
using Flink.Infraestructure.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

//RegistarAutenticación con JWT

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    //Se definen parametros de validacion del token
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "https://localhost:7238",
        ValidAudience = "https://localhost:7238",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("asdasdadasdasdasdgjdkwalsk"))
    };
});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
