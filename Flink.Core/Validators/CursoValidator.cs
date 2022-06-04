using Flink.Application.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Validators
{
    public class CursoValidator : AbstractValidator<CursoRequest>
    {

        public CursoValidator()
        {
            RuleFor(x => x.UrlCurso)
                    .NotEmpty()
                    .WithMessage("URL del curso requerido");

        }
    }
}
