using FluentValidation;

namespace BerthaLutzStore.Application.Models.DeleteProduct
{
    public class DeleteProductRequest
    {
        public int IdProduct { get; set; }
    }

    public class DeleteProductRequestValidator : AbstractValidator<DeleteProductRequest>
    {
        public DeleteProductRequestValidator()
        {
            RuleFor(r => r.IdProduct)
                .NotEmpty()
                .WithMessage("\'IdProduct\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdProduct\' cannot be null.");
        }
    }
}
