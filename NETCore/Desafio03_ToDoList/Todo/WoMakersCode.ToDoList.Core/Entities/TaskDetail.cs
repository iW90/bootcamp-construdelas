using System;
using System.Collections.Generic;

namespace WoMakersCode.ToDoList.Core.Entities
{
    public class TaskDetail
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public bool Executado { get; set; }
        public TaskList TaskList { get; set; }
        public int IdTaskList { get; set; }
        public List<Alarm> Alarms { get; set; }
    }
}
