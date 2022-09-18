using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.SearchAllProducts;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;
using System.Collections.Generic;

namespace BerthaLutzStore.Application.UseCases
{
    public class SearchAllProductsUseCase : IUseCaseAsync<SearchAllProductsRequest, List<IActionResult>>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public SearchAllProductsUseCase(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<IActionResult>> ExecuteAsync(SearchAllProductsRequest request)
        {
            var products = await _repository.SearchAll();
            var productsResponse = _mapper.Map<List<IActionResult>>(products);

            return productsResponse;
        }
    }
}
