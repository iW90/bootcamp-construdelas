using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.UpdateOrder;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;
using System.Linq;
using System.Collections.Generic;

namespace BerthaLutzStore.Application.UseCases
{
    public class UpdateOrderUseCase : IUseCaseAsync<UpdateOrderRequest, IActionResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public UpdateOrderUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(UpdateOrderRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            var validator = new UpdateOrderRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErrors = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErrors += error.ErrorMessage;

                throw new Exception(validatorErrors);
            }

            var order = await _repository.SearchAux(request.IdOrder);

            order.PaymentType = request.PaymentType;

            order.OrderedItems = new List<ItemOrder>();

            foreach (var orderItem in request.OrderedItems)
            {
                order.OrderedItems.Add(new ItemOrder()
                {
                    IdProduct = orderItem.IdProduct,
                    Quantity = orderItem.Quantity,
                    UnitPrice = orderItem.UnitPrice
                });
            }

            order.Total = order.OrderedItems.Sum(s => s.UnitPrice * s.Quantity);

            await _repository.Update(order);

            return new OkResult();
        }
    }
}
