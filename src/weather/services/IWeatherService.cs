using weather.model;

public interface IWeatherService
{
    WeatherForecastModel GetForecast(DateTime now);
}