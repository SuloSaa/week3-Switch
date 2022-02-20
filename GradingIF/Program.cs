using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            // prog küsib, mis hinde kasutaja sai ;
            // kui kasutaja sai "A", konsool kuvab "suurepärande",
            // .... kui "B", kons kuvab "Väga hea!";
            //.... kui "C", kons kuvab "Hea!";
            // .... kui "D", kons kuvab "Rahuldav!";
            //.... kui "E", kons kuvab "Kasin!";
            //.... kui "F", kons kuvab "Puudulik";
            // kui kasutaja sisestab midagi muud = "Vale väärtus";

                                // IF KAUSAMINE

            Console.WriteLine("Sisestage oma tulemus:");
            //Char- character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());
            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
                
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else

            {
                Console.WriteLine($"{userResult}: on vale väärtus");
            }
                

        }
    }
}
