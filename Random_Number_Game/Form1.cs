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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Get_a_Number sayiBul;
        private void button1_Click(object sender, EventArgs e)
        {
            
            

           
            int tahmin = Convert.ToInt32(textBox1.Text);
            

            if (sayiBul.bul(tahmin) == Get_a_Number.result.tamam)
            {
                label1.Text = "Sayıyı Buldun Tebrikler!!!";
                button1.Enabled = false;               
                label3.Visible = false;
            }
            if (sayiBul.bul(tahmin) == Get_a_Number.result.yukarı)
            {
                sayiBul.hak--;
                sayiBul.can -= 100;
                label1.Text = "Yukarı";
                textBox1.Clear();
            }
             if(sayiBul.bul(tahmin) == Get_a_Number.result.asagı)
            {
                sayiBul.hak--;
                sayiBul.can -= 100;
                label1.Text = "Aşağı";
                textBox1.Clear();
            }

          
            label3.Text = "Kalan Hakkınız="+sayiBul.hak.ToString();
            label4.Text = "Kalan Canınız="+sayiBul.can.ToString();
            if (sayiBul.hak==0)
            {
                label4.Text = "Hakkınız Bitmiştir.Kalan Hakkınız=" + sayiBul.hak.ToString();
                button1.Enabled = false;
                label1.Visible = false;             
                label3.Visible = false;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayiBul = new Get_a_Number();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DENEME D = new DENEME();
            this.Hide();
            D.Show();
        }
    }
}
