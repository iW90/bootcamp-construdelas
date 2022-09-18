using FluentValidation;
using System.Collections.Generic;

namespace BerthaLutzStore.Application.Models.UpdateOrder
{
    public class UpdateOrderRequest
    {
        public int IdOrder { get; set; }
        public int IdUser { get; set; }
        public string PaymentType { get; set; }
        public List<UpdateItemOrderRequest> OrderedItems { get; set; }
    }

    public class UpdateOrderRequestValidator : AbstractValidator<UpdateOrderRequest>
    {
        public UpdateOrderRequestValidator()
        {
            RuleFor(r => r.IdOrder)
                .NotEmpty()
                .WithMessage("\'IdOrder\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdOrder\' cannot be null.");
            RuleFor(r => r.IdUser)
                .NotEmpty()
                .WithMessage("\'IdUser\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdUser\' cannot be null.");
            RuleFor(r => r.PaymentType)
                .NotEmpty()
                .WithMessage("\'PaymentType\' cannot be empty.")
                .NotNull()
                .WithMessage("\'PaymentType\' cannot be null.");
            RuleForEach(r => r.OrderedItems)
                .NotEmpty()
                .WithMessage("\'OrderedItems\' cannot be empty.")
                .NotNull()
                .WithMessage("\'OrderedItems\' cannot be null.");
        }
    }
}
