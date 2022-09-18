using FluentValidation;

namespace BerthaLutzStore.Application.Models.UpdateUser
{
    public class UpdateUserRequest
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserRequestValidator()
        {
            RuleFor(r => r.IdUser)
                .NotEmpty()
                .WithMessage("\'IdUser\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdUser\' cannot be null.");
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