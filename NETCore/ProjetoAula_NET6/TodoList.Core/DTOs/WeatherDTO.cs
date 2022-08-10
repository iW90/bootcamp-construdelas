

namespace TodoList.Core.DTOs
{
    public class WeatherDTO
    {
        //public string name { get; set; }
        public List<Weather> weather { get; set; }
    }

    public class Weather
    {
        public string main { get; set; }
        //public string description { get; set; }
    }
}
