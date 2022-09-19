using BerthaLutzStore.Application.Models.NewProduct;
using BerthaLutzStore.Application.Models.UpdateProduct;
using BerthaLutzStore.Application.Models.DeleteProduct;
using BerthaLutzStore.Application.Models.SearchProduct;
using BerthaLutzStore.Application.Models.SearchAllProducts;
using BerthaLutzStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BerthaStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUseCaseAsync<NewProductRequest, IActionResult> _newProductCaseAsync;
        private readonly IUseCaseAsync<UpdateProductRequest, IActionResult> _updateProductCaseAsync;
        private readonly IUseCaseAsync<DeleteProductRequest, IActionResult> _deleteProductCaseAsync;
        private readonly IUseCaseAsync<SearchProductRequest, IActionResult> _searchProductCaseAsync;
        //private readonly IUseCaseAsync<SearchAllProductsRequest, IActionResult> _searchAllProductsCaseAsync;

        public ProductController(
            IUseCaseAsync<NewProductRequest, IActionResult> newProductCaseAsync,
            IUseCaseAsync<UpdateProductRequest, IActionResult> updateProductCaseAsync,
            IUseCaseAsync<DeleteProductRequest, IActionResult> deleteProductCaseAsync,
            IUseCaseAsync<SearchProductRequest, IActionResult> searchProductCaseAsync)
        //IUseCaseAsync<SearchAllProductsRequest, IActionResult> searchAllProductsCaseAsync)
        {
            _newProductCaseAsync = newProductCaseAsync;
            _updateProductCaseAsync = updateProductCaseAsync;
            _deleteProductCaseAsync = deleteProductCaseAsync;
            _searchProductCaseAsync = searchProductCaseAsync;
            //_searchAllProductsCaseAsync = searchAllProductsCaseAsync;
        }

        //New Product
        [HttpPost("NewProduct")]
        public async Task<IActionResult> Post([FromBody] NewProductRequest request)
        {
            return await _newProductCaseAsync.ExecuteAsync(request);
        }

        //Update Product by Id
        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> Put([FromBody] UpdateProductRequest request)
        {
            return await _updateProductCaseAsync.ExecuteAsync(request);
        }

        //Delete Product by Id
        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductRequest request)
        {
            var productId = await _deleteProductCaseAsync.ExecuteAsync(request);
            if (productId == null)
                return new NotFoundObjectResult("Id not found");
            return new OkObjectResult(productId);
        }

        //Search Product by Id
        [HttpGet("SearchProduct")]
        public async Task<IActionResult> Get([FromQuery] SearchProductRequest request)
        {
            var productId = await _searchProductCaseAsync.ExecuteAsync(request);
            if (productId == null)
                return new NotFoundObjectResult("Id not found");
            return new OkObjectResult(productId);
        }

        //Search All Products
        //[HttpGet("SearchAllProducts")]
        //public async Task<IActionResult<List<SearchAllProductsResponse>>> Get([FromQuery] SearchAllProductsRequest request)
        //{
        //    return await _searchAllProductsCaseAsync.ExecuteAsync(request);
        //}
    }
}
