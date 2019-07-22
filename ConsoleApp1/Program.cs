using System;
using System.Text.RegularExpressions;
using ConsoleApp1;

namespace ExamCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1: \n");
            var people = new People("Marry", true, 25);
            Console.WriteLine(people);
            people.Age += 10;
            Console.WriteLine("Person detail (apter incrementing age): ");
            Console.WriteLine(people);
            Console.WriteLine("\n");
            
            
            Console.WriteLine("Exercise 2: \n");
            Console.WriteLine("Enter the string: ");
            var str = Console.ReadLine();
            Console.WriteLine("Enter a word search: ");
            var search = Console.ReadLine();
            var count = Regex.Matches(str, search).Count;
            Console.WriteLine("Word found {0} times in the string.", count);
        }
    }
}


