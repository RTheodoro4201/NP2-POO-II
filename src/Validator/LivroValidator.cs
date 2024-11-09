using POO_II_NP2_WinForms.Model;
using FluentValidation;

namespace POO_II_NP2_WinForms.Validator;

public class LivroValidator : AbstractValidator<Livro>
{
    public LivroValidator()
    {
        RuleFor(livro => livro.Titulo)
            .NotEmpty().WithMessage("O título do livro deve ser informado.")
            .MinimumLength(3).WithMessage("O título deve conter ao menos 3 caracteres.");

        RuleFor(livro => livro.Autor)
            .NotEmpty().WithMessage("O nome do autor deve ser informado.")
            .MinimumLength(3).WithMessage("O nome do autor deve ter no mínimo 3 caracteres.")
            .Matches(@"^[a-zA-Zà-úÀ-Ú\s\-\']+$").WithMessage("O nome do autor deve conter apenas letras, acentos, espaços, hífens e apóstrofos.")
            .Must(autor => char.IsLetter(autor[0])).WithMessage("A primeira letra do nome do autor deve ser uma letra.");

        RuleFor(livro => livro.Genero)
            .NotEmpty().WithMessage("O gênero do livro deve ser informado.")
            .MinimumLength(3).WithMessage("O gênero do livro deve conter ao menos 3 caracteres.")
            .Matches(@"^[a-zA-Zà-úÀ-Ú\s\-\']+$").WithMessage("O gênero do livro deve conter apenas letras, acentos, espaços, hífens e apóstrofos.")
            .Must(genero => char.IsLetter(genero[0])).WithMessage("A primeira letra do gênero deve ser uma letra.");

        RuleFor(livro => livro.Editora)
            .NotEmpty().WithMessage("A editora do livro deve ser informado.")
            .MinimumLength(3).WithMessage("A editora do livro deve conter ao menos 3 caracteres.");
    }
}