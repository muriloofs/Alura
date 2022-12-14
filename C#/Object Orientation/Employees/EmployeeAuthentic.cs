using bytebank_ADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public abstract class EmployeeAuthentic : Employee, IAuthentic
    {
        protected EmployeeAuthentic(string cpf, double salary) : base(cpf, salary)
        {
        }
        public string Password { get; set; }
        public string Email { get; set; }

        public bool Authenticate(string password, string email)
        {
            return (Password == password && Email == email);
        }
    }
}
