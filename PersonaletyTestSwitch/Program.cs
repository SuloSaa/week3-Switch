using System;

namespace PersonaletyTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prog küsib sisestada kasutaja lemmik värv ;
            // kui kasutaja isestab "punane", konsool kuva "oled romantiline";
            // kui kasutaja sisestab "sinine", konsool kuvab " oled töökas" ;
            // kui kasutaja sisestab "rohline ", konsool kuvab " olooduse sõber" ;
            //kui kasutaja sisestab midagi muud, konsool kuvab " oled {userColor} ükssarvik ;

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor) 
            {
                case "punane": //if(userColor == "punane")
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }

            Console.WriteLine("Kena päeva!");
            //Punane,Sinine,Roheline

        }
    }
}
