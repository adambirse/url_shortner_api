
using weather.model;

namespace services.weather
{
    public class WeatherService
    {
        public WeatherForecastModel GetForecast(DateTime now)
        {
            return new WeatherForecastModel(now);
        }
    }
}