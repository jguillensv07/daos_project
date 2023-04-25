using FluentValidation;

namespace Aplicacion.Feautres.Libros.Comandos.CrearLibro
{
    public class CrearLibroValidacion : AbstractValidator<CrearLibro>
    {
        public CrearLibroValidacion()
        {
            RuleFor(p => p.TituloLibro)
                .NotEmpty().WithMessage("{PropertyName} no puede ir vacio")
                .MaximumLength(200).WithMessage("{PropertyName} no debe de exceder de {MaxLength} caracteres");

            RuleFor(p => p.CantidadPaginas)
               .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");

            RuleFor(p => p.Editorial)
               .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");

            RuleFor(p => p.CantidadPaginas)
             .NotEmpty().WithMessage("{PropertyName} no puede ir vacio");
        }
    }
}