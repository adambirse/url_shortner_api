namespace test;
using services.weather;
using weather.model;

public class WeatherServiceTest
{
    [Theory(DisplayName = "GetForecast should return a forecast with the correct date")]
    [InlineData("2023-01-01")]
    [InlineData("2023-06-15")]
    [InlineData("2023-12-31")]
    public void GetForecast_ReturnsForecastWithCorrectDate(string dateString)
    {
        // Arrange
        WeatherService service = new WeatherService();
        DateTime date = DateTime.Parse(dateString);

        // Act
        WeatherForecast forecast = service.GetForecast(date);

        // Assert
        Assert.Equal(date, forecast.Date);
    }
}

