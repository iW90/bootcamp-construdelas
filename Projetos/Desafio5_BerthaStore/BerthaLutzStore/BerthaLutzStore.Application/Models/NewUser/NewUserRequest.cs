using FluentValidation;

namespace BerthaLutzStore.Application.Models.NewUser
{
    public class NewUserRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public class NewUserRequestValidator : AbstractValidator<NewUserRequest>
    {
        public NewUserRequestValidator()
        {
            RuleFor(r => r.UserName)
                .NotEmpty()
                .WithMessage("\'UserName\' cannot be empty.")
                .NotNull()
                .WithMessage("\'UserName\' cannot be null.");
            RuleFor(r => r.Email)
                .NotEmpty()
                .WithMessage("\'Email\' cannot be empty.")
                .NotNull()
                .WithMessage("\'Email\' cannot be null.");
            RuleFor(r => r.Address)
                .NotEmpty()
                .WithMessage("\'Address\' cannot be empty.")
                .NotNull()
                .WithMessage("\'Address\' cannot be null.");
        }
    }
}
