using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    class Calculations
    {
        public Double value = 0;
        public String value2 = "";
        public String operation = "";
        public bool operation_clicked = false;
        public bool equals_clicked = false;
        public bool num_clicked = false;
        public Double memorynum = 0;

        public void result()
        {
            if (operation == "+")
            {
                value2 = Convert.ToString(value + Double.Parse(value2));
            }

            if (operation == "-")
            {
                value2 = Convert.ToString(value - Double.Parse(value2));
            }

            if (operation == "*")
            {
                value2 = Convert.ToString(value * Double.Parse(value2));
            }

            if (operation == "/")
            {
                value2 = Convert.ToString(value / Double.Parse(value2));
            }

            operation_clicked = false;
            value = Double.Parse(value2);
            operation = "";
        }
    }
}
