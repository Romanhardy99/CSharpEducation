using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name, 0)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Отработанное время: {HoursWorked}, Почасовая ставка {HourlyRate}, Зарплата: {CalculateSalary():C}";
        }
    }
}
