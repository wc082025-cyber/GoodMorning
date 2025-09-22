

namespace GoodMorning
{


    public class SnakkJakke
    {
        public static string ForslagJakke(int temp)
        {

            if (temp < 1)
                return "Det er kaldt ute. husk å ta på deg nok klær.";

            else if (temp < 14)
                return "Det er litt kjølig ute, du bør nok ta på deg en jakke.";

            else if (temp > 18)
                return "Det er fin temperatur ute. Hvis solen skinner, bør du smøre med solkrem.";

            else if (temp > 23)
                return "Det er veldig varmt ute. Hold deg i skyggen hvis du er ute i dag";

            else
                return "Spør noen om hjelp hvis du lurer på noe annet i dag."; 


        }

    }
}