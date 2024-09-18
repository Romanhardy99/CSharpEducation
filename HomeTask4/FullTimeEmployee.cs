using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, decimal baseSalary) : base(name, baseSalary) { }

        public override decimal CalculateSalary()
        {
            return BaseSalary;
        }

        public override string ToString()
        {
            return $"Имя: {Name} Зарплата: {BaseSalary:C}";
        }
    }
}
