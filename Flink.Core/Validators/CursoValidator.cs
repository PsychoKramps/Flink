using Flink.Application.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Validators
{
    public class CursoValidator : AbstractValidator<GetCursoRequest>
    {

        public CursoValidator()
        {
            RuleFor(x => x.UrlCurso)
                    .NotEmpty()
                    .WithMessage("Campo requerido");

            RuleFor(x => x.NombreCurso)
                    .NotEmpty()
                    .WithMessage("Campo requerido");

            RuleFor(x => x.Descripcion)
                    .NotEmpty()
                    .WithMessage("Campo requerido");

            RuleFor(x => x.Categoria)
                    .NotEmpty()
                    .WithMessage("Campo requerido");

        }
    }
}
