using System;
using System.Collections.Generic;

namespace BerthaLutzStore.Application.Models.SearchOrder
{
    public class SearchOrderResponse
    {
        public int IdOrder { get; set; }
        public int IdUser { get; set; }
        public string PaymentType { get; set; }
        public DateTime ShippingDate { get; set; }
        public List<SearchOrderedItemsRequest> OrderedItems { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public DateTime OrderedAt { get; set; }
    }
}
