using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outref
{

    internal class Program
    {
        public static bool parseDouble(String test,out double outDouble)
        {
            return double.TryParse(test, out outDouble);
        }



        static void Main(string[] args)
        {
            var test = "1.5";
            var outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            test = "Ronan";
            outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test value is {0}", outDouble);


        }
    }
}
