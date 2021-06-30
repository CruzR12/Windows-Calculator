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
        public String operation = "";
        public bool operation_clicked = false;
        public Double memorynum = 0;
        public String textresult = "";
        public String numbertext = "";
        public String numberclicked = "";
        public String operatortext = "";
        public String operatorclicked = "";

        public void number()
        {
            if ((textresult == "0") || (operation_clicked))
            {
                textresult = "";
            }
            else
            {
                textresult += numbertext;
            }
            operation_clicked = false;
            numbertext = numberclicked;
            if (numbertext == ".")
            {
                if (!textresult.Contains("."))
                {
                    textresult = textresult + numbertext;
                }
            }
        }

        public void operators()
        {
            operatortext = operatorclicked;
            if (value != 0)
            {
                operation_clicked = true;
                operation = operatortext;
            }
            else
            {
                operation = operatortext;
                value = Double.Parse(textresult);
                operation_clicked = true;
            }
        }
    }
}
