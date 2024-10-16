using Microsoft.AspNetCore.Mvc;
using weather.model;

namespace MyApp.Namespace
{
    [Route("api/weatherV2")]
    [ApiController]
    public class WeatherForecastControllerV2 : ControllerBase
    {
        private IWeatherService weatherService;

        public WeatherForecastControllerV2(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        [HttpGet]
        public ActionResult<WeatherForecastModel> GetForecast()
        {
            return this.weatherService.GetForecast(DateTime.Now);
        }
    }
}
