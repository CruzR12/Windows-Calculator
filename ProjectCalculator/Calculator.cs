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

        private void numbutton_Click(object sender, EventArgs e)
        {
            if ((result_box.Text == "0")||(operation_clicked))
            {
                result_box.Text = "";
            }
            if (equals_clicked)
            {
                result_label.Text = "";
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
            operation = b.Text;
            value = Double.Parse(result_box.Text);
            operation_clicked = true;
            result_label.Text = value + " " + operation;
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
                result_box.Text = (value * Double.Parse(result_box.Text)).ToString();
            }

            if (operation == "/")
            {
                result_box.Text = (value / Double.Parse(result_box.Text)).ToString();
            }
            result_label.Text = result_label.Text + " " + value;
            operation_clicked = false;
            equals_clicked = true;
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
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            result_box.Clear();
            value = 0;
            result_box.Text = "0";
            result_label.Text = "";
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
                default:
                    break;
            }
        }
    }
}
