using System;

namespace Function_is_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Staring Project here - GitHub
            Console.WriteLine(EstPremier(2));
        }

        public static bool EstPremier(int nombre)
        {
            int nbDivisions = 0;

            for (int i = 1; i <= nombre; i++)
            {
                if (nombre % i == 0)
                {
                    nbDivisions++;
                }
            }
            return nbDivisions == 2;
        }
    }
}
