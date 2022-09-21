using FluentValidation;

namespace BerthaLutzStore.Application.Models.UpdateOrder
{
    public class UpdateOrderedItemsRequest
    {
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
