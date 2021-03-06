using System;

namespace Number.ConApp
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Console.WriteLine("Number App!");                    // Set as Startup Projekt
            string input, output, output2;
            long number;

            //Eingabe (E)
            do
            {
                Console.Write("Geben Sie eine Zahl ein: ");
                input = Console.ReadLine();

            } while (long.TryParse(input, out number) == false);

            //Verarbeitung (V)

            if (Number.Logic.NumberProperty.IsPerfect(number))
            {
                output = $"\t{number} ist eine perfekte Zahl";
            }
            else
            {
                output = $"\t{number} ist KEINE perfekte Zahl";
            }

            //Ausgabe

            if (Number.Logic.NumberProperty.IsPrime(number))
            {
                output2 = $"\t{number} ist eine Primzahl";
            }
            else
            {
                output2 = $"\t{number} ist KEINE Primzahl";
            }

            Console.WriteLine(output);
            Console.WriteLine(output2);

        }
    }
}
