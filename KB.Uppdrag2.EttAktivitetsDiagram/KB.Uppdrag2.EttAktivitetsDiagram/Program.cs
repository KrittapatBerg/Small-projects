using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Uppdrag2.EttAktivitetsDiagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: "); // mata in åldern
            int age = Convert.ToInt32(Console.ReadLine()); //lagras i variabeln int 
            int money = 15000; //följ efter diagram 
             
            do // do while loop 
            {
                
                if (money > 20000 || age < 60) //om money är mer än 20000 eller age är mindre än 60
                {
                    Console.WriteLine("You are saving little"); // skriv ut "You are saving little"
                    money = money +500; // lägger till 500 till variabeln money
                }
                else //annars 
                {
                    Console.WriteLine("You are saving a lot"); //skriv ut "You are saving a lot"
                    money = money + 1000; // lägger till 1000 till variabeln money
                }
                
                Console.WriteLine(age);
                age++; //ökar med ett dvs adderar 1 till variabeln age
            } while (money < 20000 && age < 65); //så länge till variabeln money är mindre än 20 000 ska loopen köras
            Console.WriteLine("You are retired by the age of" + age);
            Console.WriteLine("You have saved" + money + "dollars");

           
            
            Console.ReadLine();

        }
    }
}
