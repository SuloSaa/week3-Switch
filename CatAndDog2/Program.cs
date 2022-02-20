using System;

namespace CatAndDog2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like a cat or a dog?");
            string userChoice = Convert.ToChar(Console.ReadLine().ToLower();
            if (userChoice == "CAT")
            {
                Console.WriteLine("You are a home-lover.");
            }
                else (userChoice = "Dog")
            {
                Console.WriteLine("You are a partygoer.");
            }
                else if
            {
                Console.WriteLine($"You are a {userChoice} friend.");
}
        }
    }
}