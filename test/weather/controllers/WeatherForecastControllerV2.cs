using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace;
using weather.model;
using Moq;

namespace test;

public class WeatherForecastControllerV2Test
{
    [Fact]
    public void TestWeatherForecast()
    {
        DateTime now = DateTime.Now;
        var mockWeatherService = new Mock<IWeatherService>();
        mockWeatherService.Setup(x => x.GetForecast(It.IsAny<DateTime>())).Returns(new WeatherForecastModel(now));
        WeatherForecastControllerV2 controller = new WeatherForecastControllerV2(mockWeatherService.Object);
        ActionResult<WeatherForecastModel> result = controller.GetForecast();
        Assert.NotNull(result.Value);
        Assert.Equal(now, result.Value.Date);
    }
}