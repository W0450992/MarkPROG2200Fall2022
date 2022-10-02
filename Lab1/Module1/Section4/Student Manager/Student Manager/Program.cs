using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentsAndGrades = new string[studentCount, 2];

            var name = "";
            var grade = "";
            //var counter = 0;
            for (int i = 0; i < studentCount; i++)
            {
                
                Console.WriteLine("Please enter student name");
                name = Console.ReadLine();
                studentsAndGrades[i,0] = name;

              
                Console.WriteLine("Please enter student grade");
                grade = Console.ReadLine();
                studentsAndGrades[i, 1] = grade;

            }



            //foreach (var names in studentsAndGrades)
            //{
            //    foreach (var grades in studentsAndGrades)
            //    {
            //        Console.WriteLine(name +  " " + grades);
            //        //Console.WriteLine(grades);
            //    }

            //}
            for (int i = 0; i < studentCount; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine(studentsAndGrades[i, 0] + " " + studentsAndGrades[i,1]);

                }

            }



        }
    }
}
