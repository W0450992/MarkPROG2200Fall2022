using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class TaxData
    {
        //1.Attributes or Properties:
        public double ProvincialTaxWithheld;
        public double FederalTaxWithheld;
        public double DependentDeduction;
        public double TotalWithheld;
        public double TotalTakeHome;


        //2. Constructor
        // I have to declare the parameters inside the constructor. Righ?
        public TaxData(double provincial, double federal,
            double dependent, double totalWithheld, double totalTakeHome)
        {
            // ?
            //Assign the parameters to the attributes in the class.
            this.ProvincialTaxWithheld = provincial;
            this.FederalTaxWithheld = federal;
            this.DependentDeduction = dependent;
            this.TotalWithheld = totalWithheld;
            this.TotalTakeHome = totalTakeHome;
        }



    }
}
