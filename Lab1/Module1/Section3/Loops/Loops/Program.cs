using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var count = 0;
            while (count < 50) { 
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    count++;
                }

                if(count < 50)
                {
                    Console.WriteLine("10");
                    Console.WriteLine("9");
                    Console.WriteLine("8");
                    Console.WriteLine("7");
                    Console.WriteLine("6");
                    Console.WriteLine("5");
                    Console.WriteLine("4");
                    Console.WriteLine("3");
                    Console.WriteLine("2");
                    Console.WriteLine("1");
                }

                //for (int x = 10; x >= 1; x--)
                //{
                //    Console.WriteLine(x);
                //    count--;
                //    Console.WriteLine(count);

                //}

          }






        }
    }
}
