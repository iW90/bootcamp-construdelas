using System;
using System.Collections.Generic;

namespace BerthaLutzStore.Core.Entities
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
        public int Storage { get; set; }
        public DateTime RegisteredAt { get; set; }
        public List<ItemOrder> OrderedItems { get; set; }
    }
}
