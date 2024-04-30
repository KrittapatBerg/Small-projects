using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Uppdrag1_Det_hemliga_talet_del_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Krittapat Berg) Här använder jag Random kod från uppgift beskrivning
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 101); 
            Console.WriteLine(slump_tal); //Jag lämnar denna rad här för att visa att slump tal/ det hemliga tal del 1 fungerar. 

            //Jag använder do while för att programmet fortsätter till användaren/ spelaren gissar rätt
            do
            {
                //Jag ber spelaren gissa ett tal som sedan lagras i variabeln int 
                Console.Write("Gissa ett tal mellan 1 och 100 : ");
                int nummer = Convert.ToInt32(Console.ReadLine());
            
            //Om talet som pragrammet får är mer än slump talet, skriver programmet ut och spelaren får gissa igen
            if (nummer > slump_tal)
                {
                    Console.WriteLine("Talet du gissar är för högt. Gissa igen...");
                }

            //Om talet är mindre än slump talet, skriver programmet ut och spelaren får gissa och fortsätta till spelaren gissar rätt
            else if (nummer < slump_tal)
                {
                    Console.WriteLine("Talet du gissar är för lågt. Gissa igen...");
                }

            else if (nummer == slump_tal)
            //När spelaren gissar rätt dvs slump talet är lika med talet som programmet får från spelaren, skriver programmet att spelaren har rätt
                {
                    Console.WriteLine("Grattis! Du gissar Rätt!");
                    break; //sedan avslutar loop med break
                }
            } while (true);

            Console.WriteLine("Tryck ENTER för att avsluta. Tack att du spelade :) "); 
            //för ett tydligt kommunikation att stänga av programmet 

            Console.ReadLine(); 
            
        }
    }
}
