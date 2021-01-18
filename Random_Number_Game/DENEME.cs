using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Sayı_Bulma_Oyunu
{
    public partial class DENEME : Form
    {
        public DENEME()
        {
            InitializeComponent();
        }

        private void DENEME_Load(object sender, EventArgs e)
        {
            oyun = new Game();
        }
        Game oyun;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            oyun.Result(a);
            if (oyun.result == "Yukarı".ToString())
            {
                label1.Text = "YUKARI".ToString();
            }
            if (oyun.result == "Aşağı".ToString())
            {
                label1.Text = "AŞAĞI".ToString();
            }
            if (oyun.result == "T".ToString())
            {
                label1.Text = "TEBRİKLER BULDUNUZ".ToString();
            }
        }
    }
}
