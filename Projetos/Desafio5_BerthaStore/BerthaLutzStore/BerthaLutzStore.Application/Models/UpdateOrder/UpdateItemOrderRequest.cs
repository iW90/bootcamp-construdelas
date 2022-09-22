using FluentValidation;

namespace BerthaLutzStore.Application.Models.UpdateOrder
{
    public class UpdateItemOrderRequest
    {
        public int IdItemOrder { get; set; }
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class UpdateItemOrderRequestValidator : AbstractValidator<UpdateItemOrderRequest>
    {
        public UpdateItemOrderRequestValidator()
        {
            RuleFor(r => r.IdItemOrder)
                .NotEmpty()
                .WithMessage("\'IdItemOrder\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdItemOrder\' cannot be null.");
            RuleFor(r => r.IdProduct)
                .NotEmpty()
                .WithMessage("\'IdClient\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdClient\' cannot be null.");
            RuleFor(r => r.Quantity)
                .NotEmpty()
                .WithMessage("\'PaymentType\' cannot be empty.")
                .NotNull()
                .WithMessage("\'PaymentType\' cannot be null.");
            RuleFor(r => r.UnitPrice)
                .NotEmpty()
                .WithMessage("\'UnitPrice\' cannot be empty.")
                .NotNull()
                .WithMessage("\'UnitPrice\' cannot be null.");
        }
    }
}
