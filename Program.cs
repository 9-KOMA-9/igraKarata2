using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karta, zbrojkar = 0;
            while (zbrojkar < 31)
            {
                Console.WriteLine(" unesite kartu: ");
                Console.WriteLine(" karta mora biti u rasponu od 1 do 13: ");
                try
                {
                    karta = Convert.ToInt32(Console.ReadLine());

                    if (karta >= 1 && karta <= 13)
                    {
                        zbrojkar = zbrojkar + karta;
                    }
                }
                catch (Exception greska)
                {
                    Console.WriteLine(" unesite kartu: ");
                    Console.WriteLine(greska.Message);
                }
                
            }
            if (zbrojkar == 31)
            {
                Console.WriteLine(" cestitamo pobjrdili ste!");
            }
            if (zbrojkar > 31)
            {
                Console.WriteLine(" zbroj je veći od 31!");
            }
            Console.ReadKey();
        }
    }
}
