namespace weather.model
{
    public class WeatherForecastModel(DateTime date)
    {

        public DateTime Date { get; private set; } = date;
    }
}