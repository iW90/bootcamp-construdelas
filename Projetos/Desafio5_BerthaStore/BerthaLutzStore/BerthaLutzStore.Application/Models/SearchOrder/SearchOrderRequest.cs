using FluentValidation;

namespace BerthaLutzStore.Application.Models.SearchOrder
{
    public class SearchOrderRequest
    {
        public int IdOrder { get; set; }
    }

    public class SearchOrderRequestValidator : AbstractValidator<SearchOrderRequest>
    {
        public SearchOrderRequestValidator()
        {
            RuleFor(r => r.IdOrder)
                .NotEmpty()
                .WithMessage("\'IdOrder\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdOrder\' cannot be null.");
        }
    }
}
