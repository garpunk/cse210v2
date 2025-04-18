public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetOutdoorDetails()
    {
        return GetStandardDetails() + $"\nWeather Forecast: {_weather}";
    }

    public string GetShortDescription()
    {
        return $"Outdoor Gathering: {_title} on {_date}";
    }
}