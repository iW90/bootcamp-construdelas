namespace BerthaLutzStore.Application.Models.SearchAllOrders
{
    public class SearchAllOrderedItemsResponse
    {
        public int IdItemOrder { get; set; }
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
