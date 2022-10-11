using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
      
            decimal annualSalary = hourlyWage * HoursInYear;
            return annualSalary;
        }
        //public decimal GetHourlyWage(int annualSalary)
        //{

           
        //    return 0;
        //}



        public decimal GetHourlyWage (int annualSalary) => annualSalary / HoursInYear;

        //public TaxData TaxWithheld(int v1, int v2)
        //{
        //    return 0;
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