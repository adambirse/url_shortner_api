namespace weather.model
{
    public class WeatherForecast
    {

        public DateTime date { get; private set; }

        public WeatherForecast(DateTime date)
        {
            this.date = date;
        }

    }
}