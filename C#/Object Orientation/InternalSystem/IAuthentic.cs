using bytebank_ADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.InternalSystem
{
    public interface IAuthentic
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Authenticated (string email,string password)
        {
            return (Password == password && Email == email);
        }
    }
}
