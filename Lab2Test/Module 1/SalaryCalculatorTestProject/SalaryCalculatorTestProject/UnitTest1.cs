using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices.ComTypes;
//using Calculator;

namespace SalaryCalculatorTestProject2
{

    //to get hourly, divide annual by 2080
    //$100,006.40 / 2080 = $48.08 hr

    //to get annual, multiply hourly by 2080
    //$48.08 * 2080 = $100,006.40


    [TestClass]
    public class CalculatorTests
    {


        [TestMethod]
        public void HourlyWageTest()
        {
            //arrange
            SalaryCalculator sc = new SalaryCalculator();

            //act
            decimal hourlyWage = sc.GetHourlyWage(-1);
            //decimal annualSalary = sc.GetAnnualSalary(50);


            //assert



            //try
            //{
            Assert.AreEqual(0, hourlyWage);
            //}

            //catch
            //{

            //    throw new Exception("cannot have 0 hourly wage");
            //}



            //Assert.AreEqual(0, hourlyWage);

        }

        [TestMethod]
        public void AnnualSalaryTestNegative()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal annualSalary = sc.GetAnnualSalary(-50);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage must be greater than zero.", ex.Message);
            }
        }

        [TestMethod]
        public void AnnualHourlyWageNegative()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal hourlyWage = sc.GetHourlyWage(0);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Yearly salary must be greater than zero.", ex.Message);
            }
        }

        [TestMethod]
        public void AnnualSalaryTest()
        {
            //arrange
            SalaryCalculator sc = new SalaryCalculator();

            //act
            decimal annualSalary = sc.GetAnnualSalary(50);

            //assert
            Assert.AreEqual(104000, annualSalary);

        }



        [TestMethod]
        public void TaxWithholdingTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            TaxData taxData = sc.TaxWithheld(1000, 2);
            //Assert
            Assert.AreEqual(60.0, taxData.ProvincialTaxWithheld);
            Assert.AreEqual(250.0, taxData.FederalTaxWithheld);
            Assert.AreEqual(40.0, taxData.DependentDeduction);
            Assert.AreEqual(270.0, taxData.TotalWithheld);
            Assert.AreEqual(730.0, taxData.TotalTakeHome);
        }

    }




   


}

// i created the class library by right clicking the project and clicking add then finding the class library with .net framework
// you can add a reference by right clicking the project and clicking add then reference and it will show up under projects
//the benefit of using interfaces is it is a better alternative to implement multiple inheritances
