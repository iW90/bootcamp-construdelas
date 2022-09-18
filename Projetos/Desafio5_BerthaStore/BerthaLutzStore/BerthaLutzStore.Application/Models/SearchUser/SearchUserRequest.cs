using FluentValidation;

namespace BerthaLutzStore.Application.Models.SearchUser
{
    public class SearchUserRequest
    {
        public int IdUser { get; set; }
    }

    public class SearchUserRequestValidator : AbstractValidator<SearchUserRequest>
    {
        public SearchUserRequestValidator()
        {
            RuleFor(r => r.IdUser)
                .NotEmpty()
                .WithMessage("\'IdUser\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdUser\' cannot be null.");
        }
    }
}
