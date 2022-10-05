using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerthaLutzStore.Application.Models.UpdateOrder
{
    public class UpdateItemResponse
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}
