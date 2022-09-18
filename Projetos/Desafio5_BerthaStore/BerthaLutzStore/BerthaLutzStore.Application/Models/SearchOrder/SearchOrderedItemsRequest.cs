using FluentValidation;

namespace BerthaLutzStore.Application.Models.SearchOrder
{
    public class SearchOrderedItemsRequest
    {
        public int IdOrder { get; set; }
    }

    public class SearchOrderedItemsRequestValidator : AbstractValidator<SearchOrderedItemsRequest>
    {
        public SearchOrderedItemsRequestValidator()
        {
            RuleFor(r => r.IdOrder)
                .NotEmpty()
                .WithMessage("\'IdOrder\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdOrder\' cannot be null.");
        }
    }
}
