using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.NewUser;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class NewUserUseCase : IUseCaseAsync<NewUserRequest, IActionResult>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public NewUserUseCase(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(NewUserRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var validator = new NewUserRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErrors = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErrors += error.ErrorMessage;

                throw new Exception(validatorErrors);
            }

            var user = _mapper.Map<User>(request);

            await _repository.New(user);

            return new OkResult();
        }
    }
}
