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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            MessageBox.Show("You said '" + input + "' right? Thats so cool!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double coolNumb = double.Parse(textBox2.Text);
            double supaNumb = (((coolNumb * 6) / 3) * 27) / 4;
            MessageBox.Show(supaNumb.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sqrCan = double.Parse(textBox3.Text);
            double sqr = sqrCan * sqrCan;
            MessageBox.Show(sqr.ToString());
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double multiply = double.Parse(textBox5.Text) * double.Parse(textBox6.Text);
            MessageBox.Show(multiply.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double divide = double.Parse(textBox7.Text) / double.Parse(textBox8.Text);
            MessageBox.Show(divide.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double add = double.Parse(Add1.Text) + double.Parse(Add2.Text);
            MessageBox.Show(add.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sub = double.Parse(Sub1.Text) - double.Parse(Sub2.Text);
            MessageBox.Show(sub.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double sqr = Math.Sqrt(double.Parse(Root.Text));
            MessageBox.Show(sqr.ToString());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Root_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sub1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sub2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
