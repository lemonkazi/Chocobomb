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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */
            
            Form Form1 = new Form1();
            
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form Form3 = new Form3();
            
            Form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();

            Form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();

            Form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Form5 = new Form5();

            Form5.Show();
        }
    }
}
