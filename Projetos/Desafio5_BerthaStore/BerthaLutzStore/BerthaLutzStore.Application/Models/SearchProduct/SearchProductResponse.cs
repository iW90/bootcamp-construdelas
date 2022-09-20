using System;

namespace BerthaLutzStore.Application.Models.SearchProduct
{
    public class SearchProductResponse
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
        public int Storage { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
