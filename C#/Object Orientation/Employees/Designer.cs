using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public class Designer : Employee
    {
        public Designer(string cpf) : base(cpf, 4000)
        {

        }

        public override double GetBonus()
        {
            return Salary * 0.17;
        }

        public override void RaiseSalary()
        {
            Salary *= 1.11;
        }
    }
}
