using Flink.Application.Requests;
using FluentValidation;

namespace Flink.Application.Validators
{
    public class UsuarioValidator : AbstractValidator<UsuarioRequest>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Nombre1)
                    .NotEmpty()
                    .WithMessage("Primer nombre obligatorio");


            RuleFor(x => x.Apellido1)
                    .NotEmpty()
                    .WithMessage("Primer apellido obligatorio");

            RuleFor(x => x.Correo)
                    .NotEmpty()
                    .WithMessage("Correo obligatorio");

            RuleFor(x => x.NombreUsuario)
                    .NotEmpty()
                    .WithMessage("Nombre de Usuario obligatorio");

            RuleFor(x => x.Contraseña)
                    .NotEmpty()
                    .Length(8)
                    .WithMessage("La contraseña debe de tener mas de 8 digitos");
        }

    }
}
