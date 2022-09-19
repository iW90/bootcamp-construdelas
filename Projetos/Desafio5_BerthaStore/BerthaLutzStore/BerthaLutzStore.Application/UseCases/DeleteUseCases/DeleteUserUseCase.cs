using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.DeleteUser;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class DeleteUserUseCase : IUseCaseAsync<DeleteUserRequest, IActionResult>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public DeleteUserUseCase(IUserRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(DeleteUserRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var user = await _repository.Search(request.IdUser);

            await _repository.Delete(user);

            return new OkResult();
        }
    }
}
