using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.SearchUser;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class SearchUserUseCase : IUseCaseAsync<SearchUserRequest, IActionResult>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public SearchUserUseCase(IUserRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(SearchUserRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var user = await _repository.Search(request.IdUser);

            var response = _mapper.Map<SearchUserResponse>(user);

            return new OkObjectResult(response);
        }
    }
}
