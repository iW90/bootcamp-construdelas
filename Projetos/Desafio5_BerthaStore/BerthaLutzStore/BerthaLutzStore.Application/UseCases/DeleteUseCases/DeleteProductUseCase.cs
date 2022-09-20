using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.DeleteProduct;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class DeleteProductUseCase : IUseCaseAsync<int, IActionResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public DeleteProductUseCase(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(int idProduct)
        {
            if (idProduct == 0)
                return new BadRequestResult();

            var product = await _repository.Search(idProduct);

            await _repository.Delete(product);

            return new OkResult();
        }
    }
}
