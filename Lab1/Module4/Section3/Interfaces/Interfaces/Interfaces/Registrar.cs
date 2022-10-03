using SchoolTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Registrar
    {
        List<IGraduate> grads = new List<IGraduate>();

        public Registrar()
        {
            grads.Add(new Student());
        }

        public Registrar(List<IGraduate> grads)
        {
            this.grads = grads;
        }
    }
}
