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

        private void numbutton_Click(object sender, EventArgs e)
        {
            if ((result_box.Text == "0")||(operation_clicked))
            {
                result_box.Text = "";
            }
            operation_clicked = false;
            Button b = (Button)sender;
            result_box.Text = result_box.Text + b.Text;

        }
        
        private void operator_button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result_box.Text);
            operation_clicked = true;
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
            operation_clicked = false;

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_all_button_Click(object sender, EventArgs e)
        {
            result_box.Text = "0";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

    }
}
