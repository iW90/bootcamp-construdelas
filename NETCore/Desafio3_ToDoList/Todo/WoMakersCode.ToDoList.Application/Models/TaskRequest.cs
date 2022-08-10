using System;

namespace WoMakersCode.ToDoList.Application.Models
{
    public class TaskRequest
    {
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public bool Executado { get; set; }
        public int IdTaskList { get; set; }
    }
}
