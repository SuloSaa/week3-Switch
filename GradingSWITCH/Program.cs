using System;

namespace GradingSWITCH
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
            // kui kasutaja sisestab midagi muud = "vale väärtus";

            // SWITCH KAUSAMINE
            Console.WriteLine("Mis hinde said:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine($"{userResult} Vale väärtus!.");
                    break;
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
