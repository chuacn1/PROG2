using System;
using System.Windows.Forms;

namespace ArithmeticCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // General method to handle operations
        private void PerformOperation(Func<double, double, double> operation)   //Func<double, double, double> is a specific delegate type that:
                                                                                //Takes two double parameters as input.
                                                                                //Returns an double as the result.
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = operation(num1, num2);

                textBox3.Text = result.ToString();
            }
            catch (FormatException)
            {
                label1.Text = "Please Enter Valid Numeric Values";
                textBox3.Text = ""; // Clear any invalid result
            }
            catch (DivideByZeroException)
            {
                label1.Text = "Cannot Divide by Zero";
                textBox3.Text = ""; // Clear the result
            }
        }

        // Event for Addition
        private void button1_Click(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 + num2);
        }

        // Event for Subtraction
        private void button5_Click(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 - num2);
        }

        // Event for Multiplication
        private void button4_Click(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 * num2);
        }

        // Event for Division
        private void button3_Click(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) =>
            {
                if (num2 == 0)
                {
                    label1.Text = "Cannot Divide by Zero";
                    textBox3.Text = ""; // Clear the result
                    return 0; // Return 0 in case of division by zero
                }
                return num1 / num2;
            });
        }

        // Clear all fields
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = ""; // Clear error message label
        }
    }
}

/*
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e) // Addition
    {
        try
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 + num2;

            textBox3.Text = result.ToString();
        }
        catch (FormatException)
        {
            label1.Text = "Please Enter Valid Numeric Values";
            textBox3.Text = ""; // Clear any invalid result
        }
    }

    private void button5_Click(object sender, EventArgs e) // Subtraction
    {
        try
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2;

            textBox3.Text = result.ToString();
        }
        catch (FormatException)
        {
            label1.Text = "Please Enter Valid Numeric Values";
            textBox3.Text = ""; // Clear any invalid result
        }
    }

    private void button4_Click(object sender, EventArgs e) // Multiplication
    {
        try
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2;

            textBox3.Text = result.ToString();
        }
        catch (FormatException)
        {
            label1.Text = "Please Enter Valid Numeric Values";
            textBox3.Text = "";
        }
    }

    private void button3_Click(object sender, EventArgs e) // Division
    {
        try
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);           

            // Check for division by zero
            if (num2 == 0)
            {
                label1.Text = "Cannot Divide by Zero";
                textBox3.Text = "";
                return;
            }



            double result = num1 / num2;

                textBox3.Text = result.ToString();

        }
        catch (FormatException)
        {
            label1.Text = "Please Enter Valid Numeric Values";
            textBox3.Text = "";
        }
    }

    private void button2_Click(object sender, EventArgs e) // Clear
    {
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
        label1.Text = "";
    }
}
}



*/
