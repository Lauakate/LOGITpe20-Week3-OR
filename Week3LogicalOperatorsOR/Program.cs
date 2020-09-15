using System;

namespace Week3LogicalOperatorsOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string Month;
            Console.WriteLine("What month were you born?");
            Month = Console.ReadLine().ToLower();
            if (Month == "december" || Month == "january" || Month == "february")
            {
                Console.WriteLine("You were born in winter.");
            }
            else if (Month == "march" || Month == "april" || Month == "may")
            {
                Console.WriteLine("You were born in spring.");
            }
            else if (Month == "june" || Month == "july" || Month == "august")
            {
                Console.WriteLine("You were born in summer.");
            }
            else if (Month == "september" || Month == "october" || Month == "november")
            {
                Console.WriteLine("You were born in autumn");
            }

        }
    }
}
