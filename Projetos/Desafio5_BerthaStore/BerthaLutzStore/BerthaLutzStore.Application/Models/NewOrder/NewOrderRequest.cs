using System.Collections.Generic;
using FluentValidation;

namespace BerthaLutzStore.Application.Models.NewOrder
{
    public class NewOrderRequest
    {
        public int IdUser { get; set; }
        public string PaymentType { get; set; }
        public List<AddItemOrderRequest> OrderedItems { get; set; }
    }

    public class NewOrderRequestValidator : AbstractValidator<NewOrderRequest>
    {
        public NewOrderRequestValidator()
        {
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
