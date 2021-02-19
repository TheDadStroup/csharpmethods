using System;

namespace FunwithMethods
{
    class Program
    {
        static void Main(string[] args)
        {   
               
            Console.WriteLine("What is your first name?");
            var userName = Console.ReadLine();


            Console.WriteLine($"Hey {userName}. What's your favorite color?");
            var color = Console.ReadLine();


            Console.WriteLine($"Those are AUsome colors. War Eagle! What is your favorite animal?");
            var animal = Console.ReadLine();


            Console.WriteLine($"That's my favorite, too. And finally, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"_-----------------------");

            Console.WriteLine($"Thanks {userName}. Here is your profile:");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");


        }
    }
}
