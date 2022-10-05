using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.NewOrder;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;
using System.Linq;

namespace BerthaLutzStore.Application.UseCases
{
    public class NewOrderUseCase : IUseCaseAsync<NewOrderRequest, IActionResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public NewOrderUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(NewOrderRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var validator = new NewOrderRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErrors = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErrors += error.ErrorMessage;

                throw new Exception(validatorErrors);
            }

            var order = _mapper.Map<Order>(request);

            order.Total = order.OrderedItems.Sum(s => s.UnitPrice * s.Quantity);

            await _repository.New(order);

            return new OkResult();
        }
    }
}
