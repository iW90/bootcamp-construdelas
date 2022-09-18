namespace BerthaLutzStore.Core.Entities
{
    public class ItemOrder
    {
        public int IdItemOrder { get; set; }
        public Order Order { get; set; }
        public int IdOrder { get; set; }
        public Product Product { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
