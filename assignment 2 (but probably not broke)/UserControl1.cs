using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2__but_probably_not_broke_
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {// try catch is in place to give an error message if the code isnt used correctly
            try
            {// double length, width and height establish those values for the equations
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                // these lines are the equations for finding surface area and volume
                double volume = length * width * height;
                double area = 2.0 * (length * height + length * width + width * height);
                //these lines use labels to display the results from the equations
                label4.Text = "volume = " + volume;
                label5.Text = "area = " + area;
            }
            // the catch is there to display an error message if the equation is done incorrectly
            catch
            {
                MessageBox.Show("there has been an error");
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {//double radius establishs that values for the equations
                double radius = double.Parse(textBox4.Text);
                // these lines are the equations for finding surface area and volume
                double area = 4.0 * Math.PI * radius * radius;
                double volume = 4.0/3.0 * Math.PI * radius * radius * radius;
                label6.Text = "volume = " + volume;
                label7.Text = "area =" + area;

            }
            //the catch is there to display an error message if the equation is done incorrectly
            catch
            {
                MessageBox.Show("an error has occured");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {//double radius and height establish those values for the equations
                double radius = double.Parse(textBox6 .Text);
                double height = double.Parse(textBox5.Text);
                // these lines are the equations for finding surface area and volume
                double area = Math.PI * radius * (radius + Math.Sqrt(height * height + radius * radius));
                double volume = 1.0 / 3.0 * Math.PI * radius * radius * height;
                label8.Text = "volume = " + volume;
                label9.Text = "area = " + area;
            }
            //the catch is there to display an error message if the equation is done incorrectly
            catch
            {
                MessageBox.Show("there is an error");
            }
        }
    }
}   
