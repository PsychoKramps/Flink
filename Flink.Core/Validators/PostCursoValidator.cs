using Flink.Application.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Validators
{
    public class PostCursoValidator : AbstractValidator<PostCursoRequest>
    {

        public PostCursoValidator()
        {
            RuleFor(x => x.UrlCurso)
                    .NotEmpty()
                    .WithMessage("Url del curso requerido");

            RuleFor(x => x.NombreCurso)
                    .NotEmpty()
                    .WithMessage("Nombre del curso requerido");

            RuleFor(x => x.Descripcion)
                    .NotEmpty()
                    .WithMessage("Descripción del curso requerido");

            RuleFor(x => x.Categoria)
                    .NotEmpty()
                    .WithMessage("Categoría del curso requerido");

        }
    }
}
