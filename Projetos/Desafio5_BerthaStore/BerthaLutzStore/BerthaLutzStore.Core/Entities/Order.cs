using System;
using System.Collections.Generic;

namespace BerthaLutzStore.Core.Entities
{
    public class Order
    {
        public int IdOrder { get; set; }
        public User User { get; set; }
        public int IdUser { get; set; }
        public decimal Total { get; set; }
        public string PaymentType { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime OrderedAt { get; set; }
        public string Status { get; set; }
        public List<ItemOrder> OrderedItems { get; set; }
    }
}
