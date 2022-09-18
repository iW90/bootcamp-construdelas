using BerthaLutzStore.Application.Models.NewProduct;
using BerthaLutzStore.Application.Models.UpdateProduct;
using BerthaLutzStore.Application.Models.DeleteProduct;
using BerthaLutzStore.Application.Models.SearchProduct;
using BerthaLutzStore.Application.Models.SearchAllProducts;
using BerthaLutzStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        private readonly IUseCaseAsync<SearchAllProductsRequest, IActionResult> _searchAllProductsCaseAsync;

        public ProductController(
            IUseCaseAsync<NewProductRequest, IActionResult> newProductCaseAsync,
            IUseCaseAsync<UpdateProductRequest, IActionResult> updateProductCaseAsync,
            IUseCaseAsync<DeleteProductRequest, IActionResult> deleteProductCaseAsync,
            IUseCaseAsync<SearchProductRequest, IActionResult> searchProductCaseAsync,
            IUseCaseAsync<SearchAllProductsRequest, IActionResult> searchAllProductsCaseAsync)
        {
            _newProductCaseAsync = newProductCaseAsync;
            _updateProductCaseAsync = updateProductCaseAsync;
            _deleteProductCaseAsync = deleteProductCaseAsync;
            _searchProductCaseAsync = searchProductCaseAsync;
            _searchAllProductsCaseAsync = searchAllProductsCaseAsync;
        }

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
        [HttpDelete]
        public async Task<IActionResult> Put([FromBody] DeleteProductRequest request)
        {
            return await _deleteProductCaseAsync.ExecuteAsync(request);
        }

        //Search Product by Id
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return await _searchProductCaseAsync.ExecuteAsync(new SearchProductRequest() { IdProduct = id });
        }

        ////Search All Products
        //[HttpGet("All")]
        //public async Task<IActionResult<List<SearchAllProductsResponse>>> Get([FromQuery] SearchAllProductsRequest request)
        //{
        //    return await _searchAllProductsCaseAsync.ExecuteAsync(request);
        //}
    }
}
