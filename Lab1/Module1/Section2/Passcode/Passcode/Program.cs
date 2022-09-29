using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passcode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the passcode");
            var code = Console.ReadLine();

            if (code == "secret")
            {
                Console.WriteLine("Authenticated");
                Console.WriteLine("Change passcode? (yes or no)");
                var yesOrNo = Console.ReadLine();
                if (yesOrNo == "yes")
                {
                    Console.WriteLine("Type new passcode.");
                    code = Console.ReadLine();
                }


            }
            else
            {
                Console.WriteLine("Wrong passcode.");
            }

        }
    }
}
