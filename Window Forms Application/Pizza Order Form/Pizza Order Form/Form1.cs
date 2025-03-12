using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza
{
    public partial class Form1 : Form
    {
        double total = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheck();
            listBox1.Items.Clear();
            listBox1.Items.Add("Small");
            total = 5;

            textBox1.Text = $"$ {total.ToString()}";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheck();
            listBox1.Items.Clear();
            listBox1.Items.Add("Large");
            total = 10;


            textBox1.Text = $"$ {total.ToString()}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (!checkBox1.Checked)
            {
                listBox1.Items.Remove("Anchovies");
                total -= 0.50;
            }
            else
            {
                listBox1.Items.Add("Anchovies");
                total += 0.50;
            }


            textBox1.Text = total.ToString("C2");

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox5.Checked)
            {
                listBox1.Items.Remove("Extra Cheese");
                total -= 1;
            }

            else
            {
                listBox1.Items.Add("Extra Cheese");
                total += 1;
            }
            textBox1.Text = total.ToString("C2");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                listBox1.Items.Remove("Olive");
                total -= 0.75;
            }

            else
            {
                listBox1.Items.Add("Olive");
                total += 0.75;
            }
            textBox1.Text = total.ToString("C2");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                listBox1.Items.Remove("Mushroom");
                total -= 0.5;
            }

            else
            {
                listBox1.Items.Add("Mushroom");
                total += 0.5;
            }
            textBox1.Text = total.ToString("C2");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                listBox1.Items.Remove("Pepperoni");
                total -= 1.50;
            }

            else
            {
                listBox1.Items.Add("Pepperoni");
                total += 1.50;
            }
            textBox1.Text = total.ToString("C2");
        }


        private void ClearButton()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

        }


        private void ClearCheck()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            ClearCheck();
            ClearButton();
            total = 0;
            textBox1.Text = $"$ {total.ToString()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls.OfType<Control>().ToList())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
            MessageBox.Show("Your order has been placed! Thank you for ordering.", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}