using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesFormGnecay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Calculator calculator = new Calculator();
        private void button1_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = Convert.ToInt32(textBox3.Text);
            double sonuc = calculator.sumoverride(s1,s2,s3);
            label2.Text = sonuc.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            double result=calculator.dividing(s1, s2);
            label2.Text = result.ToString();
        }
    }
}
