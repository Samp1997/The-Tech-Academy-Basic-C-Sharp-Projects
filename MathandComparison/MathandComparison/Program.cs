using System;

namespace MathandComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("15");
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("20");
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 1: 31,200");
            Console.WriteLine("Annual salary of Person 2: 41,600");
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            string TorF = Console.ReadLine();
            Console.WriteLine(TorF + "  Person 2 makes more money");
        }
    }
}
