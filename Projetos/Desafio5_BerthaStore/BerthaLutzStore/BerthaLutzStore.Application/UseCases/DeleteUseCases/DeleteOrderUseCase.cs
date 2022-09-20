using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.DeleteOrder;
using BerthaLutzStore.Core.Interfaces;
using BerthaLutzStore.Core.Entities;

namespace BerthaLutzStore.Application.UseCases
{
    public class DeleteOrderUseCase : IUseCaseAsync<int, IActionResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public DeleteOrderUseCase(IOrderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ExecuteAsync(int idOrder)
        {
            if (idOrder == 0)
                return new BadRequestResult();

            var order = await _repository.Search(idOrder);

            await _repository.Delete(order);

            return new OkResult();
        }
    }
}
