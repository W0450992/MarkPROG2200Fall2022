using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Survey
{

    class data
    {
        public string Name;
        public int BirthDay;
        public int BirthMonth;




        public void display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your birth day is: {0}", BirthDay);
            Console.WriteLine("Your birth month is: {0}", BirthMonth);

            if ((BirthMonth == 1 && BirthDay >= 20) || (BirthMonth == 2 && BirthDay <= 18)){
                Console.WriteLine("You're zodiac sign is: Aquarius");
            }
            else if((BirthMonth == 2 && BirthDay >= 19) || (BirthMonth == 3 && BirthDay <= 20)){
                Console.WriteLine("You're zodiac sign is: Pisces");
            }
            else if((BirthMonth == 3 && BirthDay >= 21) || (BirthMonth == 4 && BirthDay <= 19)){
                Console.WriteLine("You're zodiac sign is: Aries");
            }
            else if((BirthMonth == 4 && BirthDay >= 20) || (BirthMonth == 5 && BirthDay <= 20)){
                Console.WriteLine("You're zodiac sign is: Taurus");
            }
            else if((BirthMonth == 5 && BirthDay >= 21) || (BirthMonth == 6 && BirthDay <= 20)){
                Console.WriteLine("You're zodiac sign is: Gemeni");
            }
            else if((BirthMonth == 6 && BirthDay >= 21) || (BirthMonth == 7 && BirthDay <= 22)){
                Console.WriteLine("You're zodiac sign is: Cancer");
            }
            else if((BirthMonth == 7 && BirthDay >= 23) || (BirthMonth == 8 && BirthDay <= 22)){
                Console.WriteLine("You're zodiac sign is: Leo");
            }
            else if((BirthMonth == 8 && BirthDay >= 23) || (BirthMonth == 9 && BirthDay <= 22)){
                Console.WriteLine("You're zodiac sign is: Virgo");
            }
            else if((BirthMonth == 9 && BirthDay >= 23) || (BirthMonth == 10 && BirthDay <= 22)){
                Console.WriteLine("You're zodiac sign is: Libra");
            }
            else if((BirthMonth == 10 && BirthDay >= 23) || (BirthMonth == 11 && BirthDay <= 21)){
                Console.WriteLine("You're zodiac sign is: Scorpio");
            }
            else if((BirthMonth == 11 && BirthDay >= 22) || (BirthMonth == 12 && BirthDay <= 21)){
                Console.WriteLine("You're zodiac sign is: Sagittarius");
            }
            else
            {
                //        (($month == 12 && $day >= 22) or ($month == 1 && $day <= 19)){
                Console.WriteLine("You're zodiac sign is: Capricorn");
            }
        }
    }

    internal class Program
    {

        


        static void Main(string[] args)
        {
            var data = new data();

            Console.WriteLine("What is your name?");
            data.Name = Console.ReadLine();

            Console.WriteLine("What is your birth day? ");
            data.BirthDay = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month? (1-12)");
            data.BirthMonth = int.Parse(Console.ReadLine());

            data.display();
        }
    }
}
