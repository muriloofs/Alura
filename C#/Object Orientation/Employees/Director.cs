using bytebank_ADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public class Director:EmployeeAuthentic
    {
        public override double GetBonus()
        {
            return this.Salary * 0.5;
        }
        public Director(string cpf) : base(cpf, 5000)
        {
            //Console.WriteLine("Creating an director.");
        }
        public override void RaiseSalary()
        {
            this.Salary *= 1.15;
        }

        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
