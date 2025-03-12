using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Convert_Int__String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int sum = CalculateSum();

            displaySum.Text = sum.ToString(); // Display the sum in the displaySum TextBox


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = CalculateSum();
            double average = sum / 5;

            displayAverage.Text = average.ToString();
        }

        private int CalculateSum()
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            int number3 = Convert.ToInt32(textBox3.Text);
            int number4 = Convert.ToInt32(textBox4.Text);
            int number5 = Convert.ToInt32(textBox5.Text);

            int sum = number1 + number2 + number3 + number4 + number5;

            return sum;
        }
    }
}