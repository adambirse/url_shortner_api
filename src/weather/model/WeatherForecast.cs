namespace weather.model
{
    public class WeatherForecast(DateTime date)
    {

        public DateTime Date { get; private set; } = date;
    }
}