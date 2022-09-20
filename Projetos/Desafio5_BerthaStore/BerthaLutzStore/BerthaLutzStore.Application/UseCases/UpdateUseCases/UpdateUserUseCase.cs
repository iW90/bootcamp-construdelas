using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.UpdateUser;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class UpdateUserUseCase : IUseCaseAsync<UpdateUserRequest, IActionResult>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UpdateUserUseCase(IUserRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(UpdateUserRequest request)
        {
            var validator = new UpdateUserRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErrors = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErrors += error.ErrorMessage;

                throw new Exception(validatorErrors);
            }

            if (request == null)
                return new BadRequestResult();

            var user = _mapper.Map<User>(request);

            await _repository.Update(user);

            return new OkResult();
        }
    }
}
