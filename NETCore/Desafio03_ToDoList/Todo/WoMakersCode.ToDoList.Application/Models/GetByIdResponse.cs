using System.Collections.Generic;

namespace WoMakersCode.ToDoList.Application.Models
{
    public class GetByIdResponse
    {
        public int Id { get; set; }
        public string ListName { get; set; }
        public List<TaskResponse> Tasks { get; set; }
    }
}
