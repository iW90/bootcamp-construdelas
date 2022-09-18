using FluentValidation;

namespace BerthaLutzStore.Application.Models.SearchAllOrders
{
    public class SearchAllOrderedItemsRequest
    {
        public int IdOrder { get; set; }
    }

    public class SearchAllOrderedItemsRequestValidator : AbstractValidator<SearchAllOrderedItemsRequest>
    {
        public SearchAllOrderedItemsRequestValidator()
        {
            RuleFor(r => r.IdOrder)
                .NotEmpty()
                .WithMessage("\'IdOrder\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdOrder\' cannot be null.");
        }
    }
}
