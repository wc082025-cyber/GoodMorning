using System;

public class SnakkDayTime
{
    public static string GetGreeting()
    {
        int hour = DateTime.Now.Hour;

        if (hour < 13)
            return "hei God morgen.";
        else if (hour < 14)
            return "God ettermiddag.";

        else if (hour < 5)
            return "God natt";
        else
            return "God kveld.";
    }
}
