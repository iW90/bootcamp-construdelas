using FluentValidation;

namespace Biblioteca.Application.Models.AdicionarUsuario
{
    public class AdicionarUsuarioRequest
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }

    public class AdicionarUsuarioRequestValidator : AbstractValidator<AdicionarUsuarioRequest>
    {
        public AdicionarUsuarioRequestValidator()
        {
            RuleFor(r => r.Nome)
                .NotEmpty()
                .WithMessage("Nome não pode ser vazio.")
                .NotNull()
                .WithMessage("Nome não pode ser nulo.");
        }
    }
}
