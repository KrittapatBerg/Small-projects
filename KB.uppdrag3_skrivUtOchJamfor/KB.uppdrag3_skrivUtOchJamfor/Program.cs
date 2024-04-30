using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.uppdrag3_skrivUtOchJamfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heltal = new int[10]; // en vektor som lagrar tio positioner, heltal
            int nummer = 67;
            for (int i = 0; i < heltal.Length; i++)
            {
                Console.WriteLine("Skriv ett heltal: "); //be användaren skriva in tal
                heltal[i] = Convert.ToInt32(Console.ReadLine()); //variabeln string konverterar till int som lagras sedan i vektorn
            }
            for (int i = 0; i < heltal.Length; i++) //for-loopen kör en gång per plats i vektorn 
            {
                if (heltal[i] == nummer) // om talet är lika med något av heltalen i vektorn  
                {
                    Console.WriteLine("Du har en match! Nummret är: " + heltal[i]); 
                    //skrivs ut att användaren har en match 
                }
            }

            Console.ReadLine();
        }
    }
}
