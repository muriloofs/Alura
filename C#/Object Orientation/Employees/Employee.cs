using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Employees
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public double Salary { get; protected set; }

        public static int TotalEmployees { get; private set; }
        public abstract double GetBonus();
        public Employee(string cpf,double salary)
        {
            this.Salary = salary;
            this.Cpf = cpf;
            TotalEmployees++;
            //Console.WriteLine("Creating an employee.");
        }
        public abstract void RaiseSalary();
    }
}
