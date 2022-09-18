using FluentValidation;

namespace BerthaLutzStore.Application.Models.SearchProduct
{
    public class SearchProductRequest
    {
        public int IdProduct { get; set; }
    }

    public class SearchProductRequestValidator : AbstractValidator<SearchProductRequest>
    {
        public SearchProductRequestValidator()
        {
            RuleFor(r => r.IdProduct)
                .NotEmpty()
                .WithMessage("\'IdProduct\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdProduct\' cannot be null.");
        }
    }
}
