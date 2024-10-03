namespace test;
using services.weather;
using weather.model;

public class WeatherServiceTest
{
    [Fact]
    public void GetForecast()
    {
        WeatherService service = new WeatherService();
        DateTime now = DateTime.Now;
        WeatherForecast forecast = service.GetForecast(now);
        Assert.Equal(now, forecast.Date);
    }
}

