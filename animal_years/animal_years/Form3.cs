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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cel = double.Parse(textBox1.Text);
            double far = (cel * 1.8) + 32;
            textBox2.Text = far.ToString();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            double far = double.Parse(textBox2.Text);
            double cel = (far - 32) / 1.8;
            textBox1.Text = "";
            textBox1.Text = cel.ToString();
        }
    }
}
