using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class EmployeeManager<T> : IEmployeeManager<T> where T : Employee
    {
        private List<T> employees = new List<T>();

        public void Add(T employee)
        {
            employees.Add(employee);
        }

        public T Get(string name)
        {
            return employees.Find(e => e.Name == name);
        }

        public void Update(T employee)
        {
            var existingEmployee = Get(employee.Name);
            if (existingEmployee != null)
            {
                existingEmployee.BaseSalary = employee.BaseSalary;
                Console.WriteLine("Данные сотрудника обновлены");
            }
            else
            {
                Console.WriteLine("Сотрудник не найден");
            }
        }

        public void Delete(T employee)
        {
            employees.Remove(employee);
            Console.WriteLine("Сотрудник удалён");
        }

        public List<T> GetAll()
        {
            return employees;
        }

    }
}
