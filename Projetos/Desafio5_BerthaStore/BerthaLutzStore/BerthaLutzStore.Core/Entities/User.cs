using System;
using System.Collections.Generic;

namespace BerthaLutzStore.Core.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }
        public List<Order> Orders { get; set; }
    }
}
