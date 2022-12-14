using bytebank_ADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public class AccountManager : EmployeeAuthentic
    {
        public AccountManager(string cpf) : base(cpf, 3500)
        {

        }
        public override double GetBonus()
        {
            return Salary * 0.25;
        }
        public override void RaiseSalary()
        {
            Salary *= 1.05;
        }
        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
