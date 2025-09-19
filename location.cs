using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class Location
{
    public async Task<(double lat, double lon)> GetCurrentLocationAsync()
    {
        using var client = new HttpClient();
        string json = await client.GetStringAsync("http://ip-api.com/json");

        using JsonDocument doc = JsonDocument.Parse(json);
        var root = doc.RootElement;

        double lat = root.GetProperty("lat").GetDouble();
        double lon = root.GetProperty("lon").GetDouble();

        return (lat, lon);
    }
}