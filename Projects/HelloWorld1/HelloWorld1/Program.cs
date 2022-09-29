using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace HelloWorld1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeSpan.FromMilliseconds(1299630020).Humanize(3));
            Console.WriteLine(TimeSpan.FromMilliseconds(3603001).Humanize(3));
            Console.WriteLine(TimeSpan.FromMilliseconds(8157019263).Humanize(3));


        }
    }
}
