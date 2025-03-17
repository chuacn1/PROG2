using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Employee employee1 = new Employee("John Doe", 28, 55000);
            Employee employee2 = new Employee("Jane Smith", 34, 68000);
            Employee employee3 = new Employee("Mike Johnson", 45, 75000);

            label1.Text = $"Name: {employee1.Name}, Age: {employee1.Age}, Salary: ${employee1.Salary}\n" +
              $"Name: {employee2.Name}, Age: {employee2.Age}, Salary: ${employee2.Salary}\n" +
              $"Name: {employee3.Name}, Age: {employee3.Age}, Salary: ${employee3.Salary}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
