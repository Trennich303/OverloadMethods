using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            instructionLabel.Text = "Enter: \n\n1 value for a circle\n2 values for a rectangle";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double result;
            try
            {

                if (value2Input.Text == "" && value3Input.Text == "")
                {
                    double value1 = Convert.ToDouble(value1Input.Text);
                    result = Perimeter(value1);
                }
                else if (value3Input.Text == "")
                {
                    double value1 = Convert.ToDouble(value1Input.Text);
                    double value2 = Convert.ToDouble(value2Input.Text);
                    result = Perimeter(value1, value2);
                }
                else
                {
                    double value1 = Convert.ToDouble(value1Input.Text);
                    double value2 = Convert.ToDouble(value2Input.Text);
                    double value3 = Convert.ToDouble(value3Input.Text);
                    result = Perimeter(value1, value2, value3);

                }



                areaOutput.Text = $"{result.ToString(".##")} units";
            }
            catch
            {
                areaOutput.Text = "Error";
            }
            }
        /// <summary>
        /// This method will calculate the area of a circle 
        /// </summary>
        /// <param name="radius">radius value to be used to </param>
        /// <returns></returns>
            public double Perimeter(double diameter)
            {
                // area = pi x r^2
                double perimeter = diameter * 3.14;
                return perimeter;
            }

            public double Perimeter(double length, double width)
            {
            double perimeter = length + length + width + width;
                return perimeter;
            }
        public double Perimeter(double sideA, double sideB, double sideC)
        {
            double perimeter = sideA + sideB + sideC;
            return perimeter;
        }
        
        }

    }
