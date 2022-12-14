using bytebank_ADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utility
{
    public class BonusManager
    {
        public double TotalBonus { get; private set; }

        public void Register(Employee employee)
        {
            this.TotalBonus += employee.GetBonus();
        }
    }
}
