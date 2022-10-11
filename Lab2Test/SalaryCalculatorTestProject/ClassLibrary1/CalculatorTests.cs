using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            if (hourlyWage <= 0)
            {
                throw new InvalidOperationException("Hourly wage must be greater than zero.");
            }

            decimal annualSalary = hourlyWage * HoursInYear;
            return annualSalary;
        }
        //public decimal GetHourlyWage(int annualSalary)
        //{
        public TaxData TaxWithheld(double weeklySalary, int numDependents)
        {
            double provincialRate = 0.06;
            double federalRate = 0.25;
            double dependentRate = 0.02;
            double provincial = weeklySalary * provincialRate;
            double federal = weeklySalary * federalRate;
            double dependent = weeklySalary * dependentRate * numDependents;
            double totalWithheld = provincial + federal - dependent;
            int totalTakeHome = Convert.ToInt32(weeklySalary - totalWithheld);

            return new TaxData(provincial,federal,dependent,totalWithheld,totalTakeHome); 
            // i have to create a new object of type TaxData and then i will create a constructor to the TaxData by passing
            // those 5 values
        }

        //    return 0;
        //}



        public decimal GetHourlyWage(int annualSalary)
        {
            if (annualSalary <= 0)
            {
                throw new InvalidOperationException("Yearly salary must be greater than zero.");
            }
            return annualSalary / HoursInYear;
        } 
        //public double TaxWithheld(double weeklySalary, double numDependents)
        //{
        //    return TaxData.TaxWithheld();
        //}

    }

   

    //public class TaxData : SalaryCalculator
    //{
    //    public decimal TaxWithheld(decimal pay, int numberofpaychecks)
    //    {
    //        return 0;
    //    }
    //}
}