
using weather.model;

namespace services.weather
{
    public class WeatherService
    {
        public WeatherForecast GetForecast(DateTime now)
        {
            return new WeatherForecast(now);
        }
    }
}