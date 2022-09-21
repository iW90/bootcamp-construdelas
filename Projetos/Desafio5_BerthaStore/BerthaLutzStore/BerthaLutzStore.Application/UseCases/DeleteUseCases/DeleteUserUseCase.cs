using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.DeleteUser;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class DeleteUserUseCase : IUseCaseAsync<int, IActionResult>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public DeleteUserUseCase(IUserRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(int idUser)
        {
            if (idUser == 0)
                return new BadRequestResult();

            var user = await _repository.SearchAux(idUser);

            await _repository.Delete(user);

            return new OkResult();
        }
    }
}
