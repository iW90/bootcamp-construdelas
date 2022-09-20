using FluentValidation;

namespace BerthaLutzStore.Application.Models.NewOrder
{
    public class AddItemOrderRequest
    {
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
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
            RuleFor(r => r.UnitPrice)
                .NotEmpty()
                .WithMessage("\'UnitPrice\' cannot be empty.")
                .NotNull()
                .WithMessage("\'UnitPrice\' cannot be null.");
        }
    }
}
