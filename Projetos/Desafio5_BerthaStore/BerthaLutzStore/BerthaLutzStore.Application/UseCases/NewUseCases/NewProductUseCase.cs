using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.NewProduct;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;
using System.Linq;

namespace BerthaLutzStore.Application.UseCases
{
    public class NewProductUseCase : IUseCaseAsync<NewProductRequest, IActionResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public NewProductUseCase(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(NewProductRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var validator = new NewProductRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErrors = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErrors += error.ErrorMessage;

                throw new Exception(validatorErrors);
            }

            var product = _mapper.Map<Product>(request);

            await _repository.New(product);

            return new OkResult();
        }
    }
}
