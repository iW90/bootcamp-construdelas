using BerthaLutzStore.Application.Models.NewOrder;
using BerthaLutzStore.Application.Models.SearchOrder;
using BerthaLutzStore.Application.Models.UpdateOrder;
using BerthaLutzStore.Application.Models.DeleteOrder;
using BerthaLutzStore.Application.Models.SearchAllOrders;
using BerthaLutzStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BerthaStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUseCaseAsync<NewOrderRequest, IActionResult> _newOrderCaseAsync;
        private readonly IUseCaseAsync<SearchOrderRequest, IActionResult> _searchOrderCaseAsync;
        private readonly IUseCaseAsync<UpdateOrderRequest, IActionResult> _updateOrderCaseAsync;
        private readonly IUseCaseAsync<int, IActionResult> _deleteOrderCaseAsync;
        private readonly IUseCaseAsync<SearchAllOrdersRequest, IActionResult> _searchAllOrdersCaseAsync;

        public OrderController(
            IUseCaseAsync<NewOrderRequest, IActionResult> newOrderCaseAsync,
            IUseCaseAsync<SearchOrderRequest, IActionResult> searchOrderCaseAsync,
            IUseCaseAsync<UpdateOrderRequest, IActionResult> updateOrderCaseAsync,
            IUseCaseAsync<int, IActionResult> deleteOrderCaseAsync,
            IUseCaseAsync<SearchAllOrdersRequest, IActionResult> searchAllOrdersCaseAsync)
        {
            _newOrderCaseAsync = newOrderCaseAsync;
            _searchOrderCaseAsync = searchOrderCaseAsync;
            _updateOrderCaseAsync = updateOrderCaseAsync;
            _deleteOrderCaseAsync = deleteOrderCaseAsync;
            _searchAllOrdersCaseAsync = searchAllOrdersCaseAsync;
        }

        //New Order
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewOrderRequest request)
        {
            return await _newOrderCaseAsync.ExecuteAsync(request);
        }

        //Update Order by Id
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateOrderRequest request)
        {
            return await _updateOrderCaseAsync.ExecuteAsync(request);
        }

        //Delete Order by Id
        [HttpDelete("{orderId}")]
        public async Task<IActionResult> Delete([FromRoute] int orderId)
        {
            return await _deleteOrderCaseAsync.ExecuteAsync(orderId);
        }

        //Search Order by Id
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] SearchOrderRequest request)
        {
            var orderId = await _searchOrderCaseAsync.ExecuteAsync(request);
            if (orderId == null)
                return new NotFoundObjectResult("Id not found");
            return new OkObjectResult(orderId);
        }

        //Search All Orders
        [HttpGet("ListAll")]
        public async Task<IActionResult> Get([FromQuery] SearchAllOrdersRequest request)
        {
            return await _searchAllOrdersCaseAsync.ExecuteAsync(request);
        }
    }
}
