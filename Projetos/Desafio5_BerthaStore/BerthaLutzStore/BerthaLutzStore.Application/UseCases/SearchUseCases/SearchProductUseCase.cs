using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.SearchProduct;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class SearchProductUseCase : IUseCaseAsync<SearchProductRequest, IActionResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public SearchProductUseCase(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(SearchProductRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var Product = _mapper.Map<Product>(request);

            //await _repository.Search(IdProduct);

            return new OkResult();
        }
    }
}
