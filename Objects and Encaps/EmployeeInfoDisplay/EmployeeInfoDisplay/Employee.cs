using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfoDisplay
{
    public class Employee
    {
        private string name;
        private int age;
        private int salary;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Salary { get => salary; set => salary = value; }

        public Employee (string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
    }
}
