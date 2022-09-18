using FluentValidation;

namespace BerthaLutzStore.Application.Models.DeleteUser
{
    public class DeleteUserRequest
    {
        public int IdUser { get; set; }
    }

    public class DeleteUserRequestValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserRequestValidator()
        {
            RuleFor(r => r.IdUser)
                .NotEmpty()
                .WithMessage("\'IdUser\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdUser\' cannot be null.");
        }
    }
}
