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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)//area button
        {
            //area of square = l x w
            int l = Convert.ToInt32(Lengthbox.Text);//converts string to int
            int w = Convert.ToInt32(Widthbox.Text);

            int area = l * w;
            Areabox.Text = area.ToString();// sets the text in the text box to the area
        }

        private void button2_Click(object sender, EventArgs e)//opens triangle form then hides this one
        {
            var TriangleForm = new Triangle();
            TriangleForm.Show();
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
