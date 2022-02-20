using System;

namespace PersonalateyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Prog küsib sisestada kasutaja lemmik värv ;
            // kui kasutaja isestab "punane", konsool kuva "oled romantiline";
            // kui kasutaja sisestab "sinine", konsool kuvab " oled töökas" ;
            // kui kasutaja sisestab "rohline ", konsool kuvab " olooduse sõber" ;
            //kui kasutaja sisestab midagi muud, konsool kuvab " oled {userColor} ükssarvik ;

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();
            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
               else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"oled {userColor} ükssarvik");
            }
            Console.WriteLine("kena peva!");
        }
    }
}
