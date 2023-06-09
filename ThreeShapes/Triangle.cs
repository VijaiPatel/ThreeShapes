using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeShapes
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//area of triangle using Heron's formula
        {
            double a=Convert.ToDouble(Side1box.Text);//side1
            double b=Convert.ToDouble(Side2box.Text);//side2
            double c=Convert.ToDouble(Side3box.Text);//side3
            double s = (a + b + c) / 2;
            double toberooted = s*((s-a)*(s-b)*(s-c));
            if (toberooted<0)//if toberooted is negative then the sides cannot make a triangle so ask for differnt input
            {
                Areabox.Text = "These sides cannot make a triangle, please try again";
            }
            else
            {
                double area = Math.Sqrt(toberooted);
                Areabox.Text = area.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)//opens square form then hides this one
        {
            var SquareForm = new Square();
            SquareForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//opens circle form then hides this one
        {
            var CircleForm = new Circle();
            CircleForm.Show();
            this.Hide();
        }
    }
}
