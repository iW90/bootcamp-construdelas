

namespace TodoList.Application.Models
{
    public class TaskResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public bool Executado { get; set; }
        public int IdTaskList { get; set; }
    }
}
