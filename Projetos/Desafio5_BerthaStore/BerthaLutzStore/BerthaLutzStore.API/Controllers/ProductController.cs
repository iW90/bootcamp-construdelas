using BerthaLutzStore.Application.Models.NewProduct;
using BerthaLutzStore.Application.Models.SearchProduct;
using BerthaLutzStore.Application.Models.UpdateProduct;
using BerthaLutzStore.Application.Models.DeleteProduct;
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
        //desacomplamento de código
        private readonly IUseCaseAsync<NewProductRequest, IActionResult> _newProductCaseAsync;
        private readonly IUseCaseAsync<SearchProductRequest, IActionResult> _searchProductCaseAsync;
        private readonly IUseCaseAsync<UpdateProductRequest, IActionResult> _updateProductCaseAsync;
        private readonly DeleteProductUseCase _deleteProductCaseAsync;
        private readonly IUseCaseAsync<SearchAllProductsRequest, IActionResult> _searchAllProductsCaseAsync;

        public ProductController(
            IUseCaseAsync<NewProductRequest, IActionResult> newProductCaseAsync,
            IUseCaseAsync<SearchProductRequest, IActionResult> searchProductCaseAsync,
            IUseCaseAsync<UpdateProductRequest, IActionResult> updateProductCaseAsync,
            DeleteProductUseCase deleteProductCaseAsync,
            IUseCaseAsync<SearchAllProductsRequest, IActionResult> searchAllProductsCaseAsync)
        {
            _newProductCaseAsync = newProductCaseAsync;
            _searchProductCaseAsync = searchProductCaseAsync;
            _updateProductCaseAsync = updateProductCaseAsync;
            _deleteProductCaseAsync = deleteProductCaseAsync;
            _searchAllProductsCaseAsync = searchAllProductsCaseAsync;
        }

        //Requisições HTTP
        //New Product
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewProductRequest request)
        {
            return await _newProductCaseAsync.ExecuteAsync(request);
        }

        //Update Product by Id
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProductRequest request)
        {
            return await _updateProductCaseAsync.ExecuteAsync(request);
        }

        //Delete Product by Id
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete([FromRoute] int productId)
        {
            return await _deleteProductCaseAsync.ExecuteAsync(productId);
        }

        //Search Product by Id
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] SearchProductRequest request)
        {
            //var productId = await _searchProductCaseAsync.ExecuteAsync(request);
            //return new OkObjectResult(productId);
            return await _searchProductCaseAsync.ExecuteAsync(request);
        }

        //List All Products
        [HttpGet("ListAll")]
        public async Task<IActionResult> Get([FromQuery] SearchAllProductsRequest request)
        {
            return await _searchAllProductsCaseAsync.ExecuteAsync(request);
        }
    }
}
