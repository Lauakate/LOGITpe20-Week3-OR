using System;

namespace TestFeedback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How did your test go?");
            string grade = Console.ReadLine().ToLower();
            switch (grade)
            {
                case "a":
                    Console.WriteLine("Excellent!");
                    break;
                case "b":
                    Console.WriteLine("Very good!");
                    break;
                case "c":
                    Console.WriteLine("Passed!");
                    break;
                case "d":
                    Console.WriteLine("Failed!");
                    break;
                default:
                    Console.WriteLine("Wasted!");
                    break;
            }

        }
    }
}
