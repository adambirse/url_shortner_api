namespace test;
using services.weather;
using weather.model;

public class WeatherServiceTest
{
    [Fact(DisplayName ="Should give a forecast for the provided date")]
    public void GetForecast()
    {
        WeatherService service = new WeatherService();
        DateTime now = DateTime.Now;
        WeatherForecast forecast = service.GetForecast(now);
        Assert.Equal(now, forecast.Date);
    }
}

