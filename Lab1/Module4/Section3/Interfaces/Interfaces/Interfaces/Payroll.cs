using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IPayee
    {
        void Pay();
    }



    internal class Payroll
    {
        


        List<IPayee> payeeList = new List<IPayee>();


        public Payroll()
        {
            payeeList.Add ( new Teacher());
            payeeList.Add (new Teacher());
            payeeList.Add (new Principal());
        }


        public void PayAll()
        {
            foreach (var payee in payeeList)
            {
                payee.Pay();
            }

        }

    }
}
