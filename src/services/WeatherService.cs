
using weather.model;

namespace services.weather
{
    public class WeatherService
    {
        public WeatherForecast getForecast(DateTime now)
        {
            return new WeatherForecast(now);
        }
    }
}