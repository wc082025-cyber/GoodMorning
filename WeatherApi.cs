using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class WeatherService
{
    private readonly HttpClient _client;

    public WeatherService()
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Add("User-Agent", "Weather/1.0");
    }

    public async Task<(double temperature, double windSpeed, bool isRaining, double precipitation)> GetCurrentWeatherAsync(double lat, double lon)
    {
        string url = $"https://api.met.no/weatherapi/locationforecast/2.0/compact?lat={lat}&lon={lon}";
        string json = await _client.GetStringAsync(url);

        using JsonDocument doc = JsonDocument.Parse(json);
        var timeseries = doc.RootElement.GetProperty("properties").GetProperty("timeseries");
        var now = timeseries[0];
        var details = now.GetProperty("data").GetProperty("instant").GetProperty("details");

        double temperature = details.GetProperty("air_temperature").GetDouble();
        double windSpeed = details.GetProperty("wind_speed").GetDouble();

        var nextHour = now.GetProperty("data").GetProperty("next_1_hours");
        double precipitation = nextHour.GetProperty("details").GetProperty("precipitation_amount").GetDouble();
        bool isRaining = precipitation > 0;

        return (temperature, windSpeed, isRaining, precipitation);
    }
}
