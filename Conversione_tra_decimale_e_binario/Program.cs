using System;

namespace Conversione_tra_decimale_e_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero da convertire ? ");
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine($"{ binary}");
            Console.WriteLine($"il corrispettivo numero binario è {binary}");
            string esadecimale=Convert.ToString(value,16);
            Console.WriteLine($"il correspettivo numero esadecimale è {esadecimale}");
            string ottale = Convert.ToString(value, 8);
            Console.WriteLine($"il correspettivo numero ottale è {ottale}");
            Console.ReadLine();
        }
    }
}
