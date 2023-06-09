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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//on click of the button brings up the square form
        {
            var SquareForm = new Square();
            SquareForm.Show();
            //this.Hide();//hides form
            
        }

        private void button2_Click(object sender, EventArgs e)// on click of circle button shows circle form
        {
            var CircleForm = new Circle();
            CircleForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)// on click of triangle button shows triangle form
        {
            var TriangleForm= new Triangle();
            TriangleForm.Show();
        }
    }
}
