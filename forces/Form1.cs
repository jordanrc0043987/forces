using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double sin(double x)
            {
                return (Math.Sin(x * Math.PI / 180.0)); 
            }
            double asin(double x)
            {
                return (Math.Asin(x * Math.PI / 180.0));
            }
            double tan(double x)
            {
                return (Math.Tan(x * Math.PI / 180.0));
            }
            double atan(double x)
            {
                return (Math.Atan(x * Math.PI / 180.0));
            }
            double cos(double x)
            {
                return (Math.Cos(x * Math.PI / 180.0));
            }
            double acos(double x)
            {
                return (Math.Acos(x * Math.PI / 180.0));
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // read force and angle from textboxes 
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);
                //Inputs the number into the equation 
                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);
                //Rewrites the answers into the lablel
                label1.Text = "Fx = " + Fx;
                label2.Text = "Fx = " = Fy;
            }
            catch
            {
                //shows a message if an error occurs
                MessageBox.Show("Your numbers are wrong, check again")
            }

        }
    }
}
