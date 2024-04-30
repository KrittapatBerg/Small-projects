using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.uppdrag3_LottaBollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lottoBollar = new int[10]; //en vektor som lagrar 10 tal 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Skriv 10 stycken heltal: ");
                lottoBollar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Random random = new Random();
            int slumptal = random.Next(1,25);
            for (int i = 0; i < lottoBollar.Length; i++)
            {
                if (slumptal == lottoBollar[i])
                {
                    Console.WriteLine("Du vinner!!! Med nummer " + lottoBollar[i]);
                }
            }
            Console.ReadLine();
            

                     
        }
    }
}
