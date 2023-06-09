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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//area
        {
            //area of circle = pi r^2
            double radius = Convert.ToDouble(Radiusbox.Text);//converts string to double

            double area = Math.PI * Math.Pow(radius, 2);//area of circle
            Areabox.Text = area.ToString();// sets the text in the text box to the area
        }

        private void button2_Click(object sender, EventArgs e)//square
        {
            var SquareForm = new Square();//opens square form then hides this one
            SquareForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//triangle
        {
            var TriangleForm = new Triangle();//opens triangle form then hides this one
            TriangleForm.Show();
            this.Hide();
        }
    }
}
