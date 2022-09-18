using FluentValidation;

namespace BerthaLutzStore.Application.Models.NewOrder
{
    public class AddItemOrderRequest
    {
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
    }

    public class AddItemOrderRequestValidator : AbstractValidator<AddItemOrderRequest>
    {
        public AddItemOrderRequestValidator()
        {
            RuleFor(r => r.IdProduct)
                .NotEmpty()
                .WithMessage("\'IdProduct\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdProduct\' cannot be null.");
            RuleFor(r => r.Quantity)
                .NotEmpty()
                .WithMessage("\'Quantity\' cannot be empty.")
                .NotNull()
                .WithMessage("\'Quantity\' cannot be null.");
        }
    }
}
