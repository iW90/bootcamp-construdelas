using FluentValidation;

namespace BerthaLutzStore.Application.Models.NewProduct
{
    public class NewProductRequest
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
        public int Storage { get; set; }
    }

    public class NewProductRequestValidator : AbstractValidator<NewProductRequest>
    {
        public NewProductRequestValidator()
        {
            RuleFor(r => r.ProductName)
                .NotEmpty()
                .WithMessage("\'ProductName\' cannot be empty.")
                .NotNull()
                .WithMessage("\'ProductName\' cannot be null.");
            RuleFor(r => r.Brand)
                .NotEmpty()
                .WithMessage("\'Brand\' cannot be empty.")
                .NotNull()
                .WithMessage("\'Brand\' cannot be null.");
            RuleFor(r => r.SalePrice)
                .NotEmpty()
                .WithMessage("\'SalePrice\' cannot be empty.")
                .NotNull()
                .WithMessage("\'SalePrice\' cannot be null.");
            RuleFor(r => r.Storage)
                .NotEmpty()
                .WithMessage("\'Storage\' cannot be empty.")
                .NotNull()
                .WithMessage("\'Storage\' cannot be null.");
        }
    }
}
