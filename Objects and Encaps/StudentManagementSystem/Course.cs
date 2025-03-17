using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Course
    {
        private Department department;
        private string code;
        private string name;
        private string description;
        private int credit;
        private int fees;

        public Course (Department department, string code, string name, string description, int credit, int fees)
        {
            this.department = department;
            this.code = code;
            this.name = name;
            this.description = description;
            this.credit = credit;
            this.fees = fees;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Credit { get => credit; set => credit = value; }
        public int Fees { get => fees; set => fees = value; }
        internal Department Department { get => department; set => department = value; }
        public string DisplayInfo() => $"Course Code: {code}, Name: {name}, Description: {description}, Credits: {credit}, Fees: {fees}, Department: {department.Name}";
    }

}
