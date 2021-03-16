using System;

namespace Funzioni
{
    public class Gestione
    {
        public static double TariffaPalestra(int n)
        {
            double prezzo = 0;

            if (n == 1)
            {
                prezzo = 115.99;

            }
            if (n == 3)
            {
                prezzo = 99.99;

            }
            if (n == 12)
            {
                prezzo = 79.99;
            }
            return prezzo;

        }
    }
}
