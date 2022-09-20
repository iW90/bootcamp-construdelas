using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.UpdateProduct;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class UpdateProductUseCase : IUseCaseAsync<UpdateProductRequest, IActionResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public UpdateProductUseCase(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(UpdateProductRequest request)
        {
            var validator = new UpdateProductRequestValidator();
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

            var product = _mapper.Map<Product>(request);

            await _repository.Update(product);

            return new OkResult();
        }
    }
}
