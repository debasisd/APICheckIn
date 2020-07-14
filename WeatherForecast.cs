using System;

namespace aspcoreapi
{
    public class WeatherForecast
    {
        public int i = 1;
        public string str = "From Branch 2";
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
