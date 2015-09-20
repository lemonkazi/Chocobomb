using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animal_years
{
    public partial class Form1 : Form
    {
        private double age = 0;
        private double newAge = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ageInput_Click(object sender, EventArgs e)
        {
            age = double.Parse(input.Text);

        }

        private void dog_Click(object sender, EventArgs e)
        {
            newAge = ((age - 2) * 4) + 21;
            output.Text = newAge.ToString();
        }

        private void cow_Click(object sender, EventArgs e)
        {
            newAge = age * 3.64;
            output.Text = newAge.ToString();
        }

        private void chick_Click(object sender, EventArgs e)
        {
            newAge = age;
            output.Text = newAge.ToString();
        }

        private void cat_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< age; i++)
            {
                if (i == 0)
                {
                    newAge = 15;
                }else if (i== 1)
                {
                    newAge = newAge + 10;
                }
                else
                {
                    newAge = newAge + 4;
                }
            }
            output.Text = newAge.ToString();
        }

        private void mouse_Click(object sender, EventArgs e)
        {
            newAge = age * 20;
            output.Text = newAge.ToString();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You type in a number in the top box, and then click 'Enter Your Age'. Then click any of the animals and the corrosponding age will popup.");
        }
    }
}
