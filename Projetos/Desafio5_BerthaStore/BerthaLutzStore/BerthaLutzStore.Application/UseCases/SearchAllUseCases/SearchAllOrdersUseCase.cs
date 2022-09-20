using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.SearchAllOrders;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;
using System.Collections.Generic;

namespace BerthaLutzStore.Application.UseCases
{
    public class SearchAllOrdersUseCase : IUseCaseAsync<SearchAllOrdersRequest, IActionResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public SearchAllOrdersUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(SearchAllOrdersRequest request)
        {
            var orders = await _repository.SearchAll();
            var ordersResponse = _mapper.Map<List<SearchAllOrdersResponse>>(orders);

            return new OkObjectResult(ordersResponse);
        }
    }
}
