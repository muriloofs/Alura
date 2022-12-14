using bytebank_ADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.InternalSystem
{
    public class InternalSystem
    {
        public bool Login(IAuthentic employee, string password, string email)
        {
            bool userAuthenticated = employee.Authenticated(email,password);
            if (userAuthenticated)
            {
                Console.WriteLine("Welcome to our system.");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect Password or Email!");
                return false;
            }
        }
    }
}
