using Flink.Application;
using Flink.Application.Inferfaces;
using Flink.Application.Interfaces;
using Flink.Application.Services;
using Flink.Domain.Application;
using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Filters;
using Flink.Infraestructure.Persistance;
using Flink.Infraestructure.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
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
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Flink",
        Description = "Estas son los endpoints disponibles para la API flink"
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
      {
        {
          new OpenApiSecurityScheme
          {
            Reference = new OpenApiReference
              {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
              },
              Scheme = "oauth2",
              Name = "Bearer",
              In = ParameterLocation.Header,

            },
            new List<string>()
          }
        });

    //Obtener de forma dinamica el nombre del archivo
    var nombreArchivo = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

    //Creamos una variable con la ruta completa del archivo
    var xmlPath = Path.Combine(AppContext.BaseDirectory, nombreArchivo);

    options.IncludeXmlComments(xmlPath);
});


builder.Services.AddDbContext<FlinkContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Flink")));

//registrar dependendencias
builder.Services.AddTransient<IUsuarioService, UsuarioService>();
builder.Services.AddTransient<ICursoService, CursoService>();
builder.Services.AddTransient<ICursoUsuarioService, UsuarioCursoService>();
builder.Services.AddTransient<IUsuarioRepository,UsuarioRepository>();
builder.Services.AddTransient<ICursoRepository, CursoRepository>();
builder.Services.AddTransient<IUsuarioCursoRepository, UsuarioCursoRepository>();

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
        ValidIssuer = builder.Configuration["Autentication:Issuer"],
        ValidAudience = builder.Configuration["Autentication:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Autentication:SecretKey"))
    };
});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(
        
        );
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
