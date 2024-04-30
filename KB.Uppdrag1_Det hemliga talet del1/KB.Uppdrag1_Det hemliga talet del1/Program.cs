using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Uppdrag1_Det_hemliga_talet_del1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Krittapat Berg) Här använder jag Random kod från uppgift beskrivning 
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 101);

            //Här skriver programmet ut ett slump tal mellan 1 och 101 för att 100 ska vara med i ett slump. 
            Console.WriteLine(slump_tal);
            
            Console.ReadLine();
            
        }
    }
}
