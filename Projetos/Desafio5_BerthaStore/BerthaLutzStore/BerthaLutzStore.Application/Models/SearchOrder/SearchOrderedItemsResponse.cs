namespace BerthaLutzStore.Application.Models.SearchOrder
{
    public class SearchOrderedItemsResponse
    {
        public int IdItemOrder { get; set; }
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
