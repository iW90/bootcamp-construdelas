using System;

namespace BerthaLutzStore.Application.Models.SearchUser
{
    public class SearchUserResponse
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
