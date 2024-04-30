using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.uppdrag3_FyllVektorn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heltal = new int[10]; // en vektor som lagrar tio positioner, heltal

            for (int i = 0; i < 10; i++) //en for-loop mall
            {
                Console.WriteLine("Skriv ett heltal: " + i); //be användaren skriva in tal
                heltal[i] = Convert.ToInt32(Console.ReadLine()); //string konvertera till int som lagras sedan i vektorn
            }
            Console.ReadLine();
        }
    }
}
