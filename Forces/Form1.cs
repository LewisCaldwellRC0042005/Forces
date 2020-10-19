using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double Tan(double x)
        {
            return (Math.Tan(x * Math.PI / 180.0));
        }

        double Atan(double x)
        {
            return (Math.Atan(x) * 180 / Math.PI);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
         //input errors for try-catch
            try
            {
                //read values from force and angles from textboxes
                double Force = double.Parse(textBox2.Text);
                double angle = double.Parse(textBox1.Text);
                //calculate Fx and fy using equations fx + fcos and fy = fsin
                double Fx = Force * cos(angle);
                double Fy = Force * sin(angle);
                //output solutions to label 1 and label2
                label1.Text = "Fx =" + Fx;
                label2.Text = "Fy =" + Fy;
            }
            catch
            { 
                MessageBox.Show("Huh?");
            }
        }


    }
}

