using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Uppdrag2.Bastun
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            bool tempKorrekt = false;
            do
            { Console.WriteLine("Välkommen");
            Console.Write("Ställ din önskad temperatur i Fahrenheit: "); //be användaren mata in temperatur
            double temp = Convert.ToDouble(Console.ReadLine()); //som lagras i variabeln double
            
            double Celcius = FahtoCel(temp); //call to metoden
 
                if (Celcius == 75) //den optimala temperaturen
                {
                    Console.WriteLine("Det är perfekt temperatur");
                    Console.ReadLine();
                    tempKorrekt=true; //stopp loopen 
                }
                else if (Celcius < 78 && Celcius > 75) // 75C-77C är godtagbara temperaturen
                {
                    Console.WriteLine("Koppla av och njut. ..");
                    Console.ReadLine(); 
                    tempKorrekt=(true); //stopp loopen 
                }
                else if (Celcius >= 78) //kontrollerar att temperaturen inte blir för varm och be användaren ställ in ny temperatur
                { 
                    Console.WriteLine("Det är för varm!!");
                }
                else //annars blir det temperaturen för kallt och be användaren ställ in ny temperatur
                {
                    Console.WriteLine("Det är för kallt, skruva upp lite");
                }
            } while (!tempKorrekt);
            
        }
        static double FahtoCel(double temp) //metod som omvandlar Fahrenheit till Celcius
        {
            temp = (temp - 32) * 5 / 9;
            Console.WriteLine("Din önskad temperatur i Celcius är " + temp); // Jag vill att det ska visa resultatet i Celcius
            return temp; //skicka resultat tillbaka 
        }
    }
}
