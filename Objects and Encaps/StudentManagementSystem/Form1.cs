using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {

        private static List<Institution> institutions;
        private static List<Department> departments;
        public Form1()
        {
            InitializeComponent();

            institutions = Utils.SeedInstitutions();
            departments = Utils.SeedDepartments();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
