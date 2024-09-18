using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public abstract decimal CalculateSalary();

        public abstract override string ToString();
    }
}
