
namespace GoodMorning;

using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Diagnostics;

class Program
{
    static async Task Main()
    {

    string greeting = SnakkDayTime.GetGreeting();

    

        /// Location is location api
    /// WeatherService is YR API
    /// 
    var location = new Location();
        var (lat, lon) = await location.GetCurrentLocationAsync();

        var weather = new WeatherService();
        var (temp, wind, rain, precip) = await weather.GetCurrentWeatherAsync(lat, lon);



        DateTime now = DateTime.Now;
        string timeText = $"{greeting}Klokken er {now:HH:mm}.Temperaturen er {temp}°C.Nedbør?:{(rain ? "Ja" : "Nei")} ({precip} mm";

        // Speak the time using macOS's built-in 'say' command
        Process.Start("say", timeText);

        // Optional: show it in console too
        Console.WriteLine(timeText);

        
        Console.WriteLine($"Temperaturen er {temp}°C");
        Console.WriteLine($" Nedbør er nå: {(rain ? "Yes" : "No")} ({precip} mm)");
        



       // Console.WriteLine("\nTrykk en knapp for å avslutte...");
        //Console.ReadKey();

    // speak lines
       // Process.Start("say",greeting);
        //Process.Start("say", timeText );
      } 


}
