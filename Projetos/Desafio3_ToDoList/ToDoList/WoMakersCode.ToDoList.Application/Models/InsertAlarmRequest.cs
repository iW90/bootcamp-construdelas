using System;

namespace WoMakersCode.ToDoList.Application.Models
{
    public class InsertAlarmRequest
    {
        public DateTime DataHora { get; set; }
        public int IdTaskDetail { get; set; }
    }
}
