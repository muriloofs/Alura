using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public class Auxiliary : Employee
    {
        public Auxiliary(string cpf) : base(cpf, 3000)
        {

        }

        public override double GetBonus()
        {
            return Salary * 0.20;
        }

        public override void RaiseSalary()
        {
            Salary *= 1.10;
        }
    }
}
