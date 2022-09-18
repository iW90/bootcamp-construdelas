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
        private readonly IUseCaseAsync<SearchAllOrdersRequest, IActionResult> _searchAllOrdersCaseAsync;

        public OrderController(
            IUseCaseAsync<NewOrderRequest, IActionResult> newOrderCaseAsync,
            IUseCaseAsync<UpdateOrderRequest, IActionResult> updateOrderCaseAsync,
            IUseCaseAsync<DeleteOrderRequest, IActionResult> deleteOrderCaseAsync,
            IUseCaseAsync<SearchOrderRequest, IActionResult> searchOrderCaseAsync,
            IUseCaseAsync<SearchAllOrdersRequest, IActionResult> searchAllOrdersCaseAsync)
        {
            _newOrderCaseAsync = newOrderCaseAsync;
            _updateOrderCaseAsync = updateOrderCaseAsync;
            _deleteOrderCaseAsync = deleteOrderCaseAsync;
            _searchOrderCaseAsync = searchOrderCaseAsync;
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
        [HttpDelete]
        public async Task<IActionResult> Put([FromBody] DeleteOrderRequest request)
        {
            return await _deleteOrderCaseAsync.ExecuteAsync(request);
        }

        //Search Order by Id
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return await _searchOrderCaseAsync.ExecuteAsync(new SearchOrderRequest() { IdOrder = id });
        }

        //Search All Orders
        //[HttpGet("All")]
        //public async Task<IActionResult<List<SearchAllOrdersResponse>>> Get([FromQuery] SearchAllOrdersRequest request)
        //{
        //    return await _searchAllOrdersCaseAsync.ExecuteAsync(request);
        //}
    }
}
