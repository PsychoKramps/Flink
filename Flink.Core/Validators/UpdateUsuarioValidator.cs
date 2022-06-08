using Flink.Application.Requests;
using FluentValidation;

namespace Flink.Application.Validators
{
    public class UpdateUsuarioValidator : AbstractValidator<CreateUsuarioRequest>
    {
        public UpdateUsuarioValidator()
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

        }

    }
}
