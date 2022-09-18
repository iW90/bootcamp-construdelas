using FluentValidation;

namespace BerthaLutzStore.Application.Models.DeleteOrder
{
    public class DeleteOrderRequest
    {
        public int IdOrder { get; set; }
    }

    public class DeleteOrderRequestValidator : AbstractValidator<DeleteOrderRequest>
    {
        public DeleteOrderRequestValidator()
        {
            RuleFor(r => r.IdOrder)
                .NotEmpty()
                .WithMessage("\'IdOrder\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdOrder\' cannot be null.");
        }
    }
}
