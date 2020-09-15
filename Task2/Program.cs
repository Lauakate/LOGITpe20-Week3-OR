using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day");
            string day = Console.ReadLine().ToLower();
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                Console.WriteLine("This is a workday");
            }
            else if (day == "saturday" || day == "sunday")
            {
                Console.WriteLine("It is a weekend!");
            }
            else
            {
                Console.WriteLine("This is not a day of the week.");
            }
        }
    }
}
