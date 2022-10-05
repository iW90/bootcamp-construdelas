using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.SearchOrder;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class SearchOrderUseCase : IUseCaseAsync<SearchOrderRequest, IActionResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public SearchOrderUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(SearchOrderRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var order = await _repository.Search(request.IdOrder);

            var response = _mapper.Map<SearchOrderResponse>(order);

            return new OkObjectResult(response);
        }
    }
}
