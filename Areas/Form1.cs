using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCircle_Click(object sender, EventArgs e)
        {
            // Calculate and display circle's perimeter and area
            double radius = Convert.ToDouble(tbxRadius.Text);
            lblPerimeter.Text = (Math.PI * 2 * radius).ToString();
            lblarea.Text = (Math.PI * Math.Pow(radius, 2)).ToString();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            // Calculate and display rectangle's area and perimeter
            double width = Convert.ToDouble(tbxWidthRec.Text);
            double height = Convert.ToDouble(tbxHeightRec.Text);
            lblAreaRec.Text = (height * width).ToString();
            lblPerimeterRec.Text = (2 * height + 2 * width).ToString();
        }

        private void btnTri_Click(object sender, EventArgs e)
        {
            // Calculate and display triangle's area and perimeter
            double side1 = Convert.ToDouble(tbxSide1.Text);
            double side2 = Convert.ToDouble(tbxSide2.Text);
            double side3 = Convert.ToDouble(tbxSide3.Text);

            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            if (Double.IsNaN(area))
            {
                // Display "Invalid Values" if the triangle is not valid
                lblAreaTri.Text = "Invalid Values";
            }
            else
            {
                // Display the calculated area
                lblAreaTri.Text = area.ToString();
            }

            lblPerimeterTri.Text = (side1 + side2 + side3).ToString();
        }
    }
}
