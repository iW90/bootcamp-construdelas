using System;

namespace WoMakersCode.ToDoList.Core.Entities
{
    public class Alarm
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int IdTaskDetail { get; set; }
        public TaskDetail TaskDetail { get; set; }
    }
}
