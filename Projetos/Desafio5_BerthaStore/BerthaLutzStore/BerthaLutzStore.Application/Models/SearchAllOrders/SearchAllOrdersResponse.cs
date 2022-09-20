using System;
using System.Collections.Generic;

namespace BerthaLutzStore.Application.Models.SearchAllOrders
{
    public class SearchAllOrdersResponse
    {
        public int IdOrder { get; set; }
        public int IdUser { get; set; }
        public string PaymentType { get; set; }
        public DateTime ShippingDate { get; set; }
        public List<SearchAllOrderedItemsResponse> OrderedItems { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderedAt { get; set; }
    }
}
