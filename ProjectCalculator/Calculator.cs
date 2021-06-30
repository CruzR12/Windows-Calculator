using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        Double value = 0;
        String operation = "";
        bool operation_clicked = false;
        bool equals_clicked = false;
        Double memorynum = 0;

        private void numbutton_Click(object sender, EventArgs e)
        {
            if ((result_box.Text == "0")||(operation_clicked))
            {
                result_box.Text = "";
            }
            operation_clicked = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result_box.Text.Contains("."))
                {
                    result_box.Text = result_box.Text + b.Text;
                }
            }
            else
            {
                result_box.Text = result_box.Text + b.Text;
            }
        }
        
        private void operator_button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equals_button.PerformClick();
                operation_clicked = true;
                operation = b.Text;
                result_label.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result_box.Text);
                operation_clicked = true;
                result_label.Text = value + " " + operation;
            }
        }

        private void equals_button_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                result_box.Text = (value + Double.Parse(result_box.Text)).ToString();
            }

            if (operation == "-")
            {
                result_box.Text = (value - Double.Parse(result_box.Text)).ToString();
            }

            if (operation == "*")
            {
                result_box.Text = (value * Double .Parse(result_box.Text)).ToString();
            }

            if (operation == "/")
            {
                result_box.Text = (value / Double.Parse(result_box.Text)).ToString();
            }

            if (result_box.Text.Contains("√"))
            {
                result_box.Text = result_box.Text.Remove(0, 1);
                result_box.Text = (Math.Sqrt(Double.Parse(result_box.Text))).ToString();
            }
            operation_clicked = false;
            equals_clicked = true;
            value = Double.Parse(result_box.Text);
            operation = "";
            result_label.Text = "";
        }

        private void sign_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text.Contains("-"))
            {
                result_box.Text = result_box.Text.Remove(0,1);
            }
            else
            {
                result_box.Text = "-" + result_box.Text;
            }
        }

        private void clear_entry_button_Click(object sender, EventArgs e)
        {
            result_box.Text = "0";
            reciprocal_button.Enabled = true;
            percent_button.Enabled = true;
            sqrt_button.Enabled = true;
            square_button.Enabled = true;
            division_button.Enabled = true;
            multiplication_button.Enabled = true;
            addition_button.Enabled = true;
            subtraction_button.Enabled = true;
            number_0.Enabled = true;
            number_1.Enabled = true;
            number_2.Enabled = true;
            number_3.Enabled = true;
            number_4.Enabled = true;
            number_5.Enabled = true;
            number_6.Enabled = true;
            number_7.Enabled = true;
            number_8.Enabled = true;
            number_9.Enabled = true;
            sign_button.Enabled = true;
            decimal_button.Enabled = true;
            equals_button.Enabled = true;
            memadd_button.Enabled = true;
            memsubt_button.Enabled = true;
            memory_button.Enabled = true;
            memrecall_button.Enabled = true;
            memclear_button.Enabled = true;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            result_box.Clear();
            value = 0;
            result_box.Text = "0";
            result_label.Text = "";
            reciprocal_button.Enabled = true;
            percent_button.Enabled = true;
            sqrt_button.Enabled = true;
            square_button.Enabled = true;
            division_button.Enabled = true;
            multiplication_button.Enabled = true;
            addition_button.Enabled = true;
            subtraction_button.Enabled = true;
            number_0.Enabled = true;
            number_1.Enabled = true;
            number_2.Enabled = true;
            number_3.Enabled = true;
            number_4.Enabled = true;
            number_5.Enabled = true;
            number_6.Enabled = true;
            number_7.Enabled = true;
            number_8.Enabled = true;
            number_9.Enabled = true;
            sign_button.Enabled = true;
            decimal_button.Enabled = true;
            equals_button.Enabled = true;
            memadd_button.Enabled = true;
            memsubt_button.Enabled = true;
            memory_button.Enabled = true;
            memrecall_button.Enabled = true;
            memclear_button.Enabled = true;
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    number_0.PerformClick();
                    break;

                case "1":
                    number_1.PerformClick();
                    break;

                case "2":
                    number_2.PerformClick();
                    break;

                case "3":
                    number_3.PerformClick();
                    break;

                case "4":
                    number_4.PerformClick();
                    break;

                case "5":
                    number_5.PerformClick();
                    break;

                case "6":
                    number_6.PerformClick();
                    break;

                case "7":
                    number_7.PerformClick();
                    break;

                case "8":
                    number_8.PerformClick();
                    break;

                case "9":
                    number_9.PerformClick();
                    break;

                case ".":
                    decimal_button.PerformClick();
                    break;

                case "+":
                    addition_button.PerformClick();
                    break;

                case "-":
                    subtraction_button.PerformClick();
                    break;

                case "*":
                    multiplication_button.PerformClick();
                    break;

                case "/":
                    division_button.PerformClick();
                    break;

                case "=":
                    equals_button.PerformClick();
                    break;

                case "%":
                    percent_button.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void sqrt_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text.Contains("√"))
            {
                result_box.Text = result_box.Text.Remove(0, 1);
            }
            else
            {
                result_box.Text = "√" + result_box.Text;
            }
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            result_box.Text = ((Double.Parse(result_box.Text) * Double.Parse(result_box.Text))).ToString();
        }

        private void reciprocal_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text == "0")
            {
                result_box.Text = "Cannot divide by zero";
                reciprocal_button.Enabled = false;
                percent_button.Enabled = false;
                sqrt_button.Enabled = false;
                square_button.Enabled = false;
                division_button.Enabled = false;
                multiplication_button.Enabled = false;
                addition_button.Enabled = false;
                subtraction_button.Enabled = false;
                number_0.Enabled = false;
                number_1.Enabled = false;
                number_2.Enabled = false;
                number_3.Enabled = false;
                number_4.Enabled = false;
                number_5.Enabled = false;
                number_6.Enabled = false;
                number_7.Enabled = false;
                number_8.Enabled = false;
                number_9.Enabled = false;
                sign_button.Enabled = false;
                decimal_button.Enabled = false;
                equals_button.Enabled = false;
                memadd_button.Enabled = false;
                memsubt_button.Enabled = false;
                memory_button.Enabled = false;
                memrecall_button.Enabled = false;
                memclear_button.Enabled = false;
            }
            else
            {
                result_box.Text = (1 / Double.Parse(result_box.Text)).ToString();
            }
        }

        private void percent_button_Click(object sender, EventArgs e)
        {
            result_box.Text = (Double.Parse(result_box.Text) / 100).ToString();
        }

        private void memclear_button_Click(object sender, EventArgs e)
        {
            memorynum = 0;
        }

        private void memrecall_button_Click(object sender, EventArgs e)
        {
            result_box.Text = memorynum.ToString();
        }

        private void memsave_button_Click(object sender, EventArgs e)
        {
            memorynum = Double.Parse(result_box.Text);
        }

        private void memadd_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text != "")
            {
                memorynum += Double.Parse(result_box.Text);
            }
        }

        private void memsubt_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text != "")
            {
                memorynum -= Double.Parse(result_box.Text);
            }
        }

        private void backspace_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text.Length > 0)
            {
                result_box.Text = result_box.Text.Substring(0, result_box.Text.Length - 1);
            }
        }
    }
}