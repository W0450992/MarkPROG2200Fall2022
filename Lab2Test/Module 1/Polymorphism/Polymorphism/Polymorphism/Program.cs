using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Employee
    {
       

        public virtual void CalculatreWeeklySalary( int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine("\n this angry employee worked {0} hours. " +
                "Paid for in 40 hours at $ {1}" + "/hr = $ {2} \n", weeklyHours, wage, salary);
            Console.WriteLine("\n");

        }

        public class Contractor : Employee
        {
            public override void CalculatreWeeklySalary(int weeklyHours, int wage)
            {
                var salary = weeklyHours * wage;
                Console.WriteLine("\n this angry employee worked {0} hours. " +
                "Paid for in 40 hours at $ {1}" + "/hr = $ {2} \n", weeklyHours, wage, salary);
            }
        }

        public class program
        {
            private static void Main(string[] args)
            {
                const int hours = 55, wage = 70;
                List<Employee> employees = GetEmployees();

                foreach (var e in employees)
                {
                    e.CalculatreWeeklySalary(hours, wage);
                }
            }

            private static List<Employee> GetEmployees()
            {
                var someEmployee = new Employee();
                var someContractor = new Contractor();
                var everyone = new List<Employee> { someEmployee, someContractor };
                return everyone;
            }

        }
    }
}
