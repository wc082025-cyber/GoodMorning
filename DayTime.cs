using System;

public class SnakkDayTime
{
    public static string GetGreeting()
    {
        int hour = DateTime.Now.Hour;

        if (hour < 6)
            return "God morgen";
        else if (hour < 14)
            return "God ettermiddag";
        else
            return "God kveld";
    }
}
