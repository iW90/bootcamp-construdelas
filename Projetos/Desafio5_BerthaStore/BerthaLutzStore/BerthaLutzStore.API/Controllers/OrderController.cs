using BerthaLutzStore.Application.Models.NewOrder;
using BerthaLutzStore.Application.Models.UpdateOrder;
using BerthaLutzStore.Application.Models.DeleteOrder;
using BerthaLutzStore.Application.Models.SearchOrder;
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
        private readonly IUseCaseAsync<UpdateOrderRequest, IActionResult> _updateOrderCaseAsync;
        private readonly IUseCaseAsync<DeleteOrderRequest, IActionResult> _deleteOrderCaseAsync;
        private readonly IUseCaseAsync<SearchOrderRequest, IActionResult> _searchOrderCaseAsync;
        //private readonly IUseCaseAsync<SearchAllOrdersRequest, IActionResult> _searchAllOrdersCaseAsync;

        public OrderController(
            IUseCaseAsync<NewOrderRequest, IActionResult> newOrderCaseAsync,
            IUseCaseAsync<UpdateOrderRequest, IActionResult> updateOrderCaseAsync,
            IUseCaseAsync<DeleteOrderRequest, IActionResult> deleteOrderCaseAsync,
            IUseCaseAsync<SearchOrderRequest, IActionResult> searchOrderCaseAsync)
        //IUseCaseAsync<SearchAllOrdersRequest, IActionResult> searchAllOrdersCaseAsync)
        {
            _newOrderCaseAsync = newOrderCaseAsync;
            _updateOrderCaseAsync = updateOrderCaseAsync;
            _deleteOrderCaseAsync = deleteOrderCaseAsync;
            _searchOrderCaseAsync = searchOrderCaseAsync;
            //_searchAllOrdersCaseAsync = searchAllOrdersCaseAsync;
        }

        //New Order
        [HttpPost("NewOrder")]
        public async Task<IActionResult> Post([FromBody] NewOrderRequest request)
        {
            return await _newOrderCaseAsync.ExecuteAsync(request);
        }

        //Update Order by Id
        [HttpPut("UpdateOrder")]
        public async Task<IActionResult> Put([FromBody] UpdateOrderRequest request)
        {
            return await _updateOrderCaseAsync.ExecuteAsync(request);
        }

        //Delete Order by Id
        [HttpDelete("DeleteOrder")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOrderRequest request)
        {
            var orderId = await _deleteOrderCaseAsync.ExecuteAsync(request);
            if (orderId == null)
                return new NotFoundObjectResult("Id not found");
            return new OkObjectResult(orderId);
        }

        //Search Order by Id
        [HttpGet("SearchOrder")]
        public async Task<IActionResult> Get([FromQuery] SearchOrderRequest request)
        {
            var orderId = await _searchOrderCaseAsync.ExecuteAsync(request);
            if (orderId == null)
                return new NotFoundObjectResult("Id not found");
            return new OkObjectResult(orderId);
        }

        //Search All Orders
        //[HttpGet("SearchAllOrders")]
        //public async Task<IActionResult<List<SearchAllOrdersResponse>>> Get([FromQuery] SearchAllOrdersRequest request)
        //{
        //    return await _searchAllOrdersCaseAsync.ExecuteAsync(request);
        //}
    }
}
