using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Your name is {0}", name);

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();
            Console.WriteLine("Your age is {0}", age);
            
            Console.WriteLine("What is your birth month?");
            var month = Console.ReadLine();
            Console.WriteLine("Your birth month is {0}", month);

            Console.WriteLine("What is your birth year?");
            var year = Console.ReadLine();
            Console.WriteLine("Your birth year is {0}", year);

            Console.WriteLine("What is your eye color?");
            var color = Console.ReadLine();
            Console.WriteLine("Your eye color is {0}", color);

        }
    }
}
