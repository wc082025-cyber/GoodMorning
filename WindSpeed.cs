namespace GoodMorning
{
    public class Wind
    {
        public static string WindSpeed(int wind_speed)
        {
            if (wind_speed < 4)
                return "";
            else
                return "I dag kan det blåse mye, det kan være lurt å ta på et skjerf.";
        }
    }
}
