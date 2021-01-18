using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YURT_OTOMASYONUU_PROJEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int b = 0, say = 6, say2 = 6;
        //--------------------BUTONLARDA KULLANICI GİRİŞİ SORGUSU--------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "a" && textBox2.Text == "a")
            {
                Okul_Tanıımı o = new Okul_Tanıımı();
                this.Hide();
                o.Show();
            }
            else if (textBox1.Text != "a" || textBox2.Text != "a")
            {
                timer1.Enabled = true;
                b++;
                label4.ForeColor = Color.Red;
                label4.Text = "Hatalı Giriş= " + b;
                if (b == 3)
                {
                    MessageBox.Show("3 KERE HATALI GİRİŞ YAPTINIZ,LÜTFEN 5 SANİYE BEKLEYİNİZ!!!");
                } 
                timer2.Enabled = true;
                if (b == 5)
                {
                    MessageBox.Show("5 KERE HATALI GİRİŞ YAPTINIZ,LÜTFEN 5 SANİYE BEKLEYİNİZ!!!");
                }
                if (b == 7)
                {
                    MessageBox.Show("7 KERE HATALI GİRİŞ YAPTINIZ,DAHA GİRİŞ YAPAMAZSINIZ");
                    button1.Enabled = false;
                }
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        //----------------------------TİMER KULLANIMLAARI-----------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b == 3)
            {
                timer1.Start();
                say--;
                label4.Text = say + " saniye bekleyiniz!!!";
                button1.Enabled = false;
            }
            if (say == 0)
            {
                timer1.Stop();
                button1.Enabled = true;
            }      
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (b == 5)
            {
                timer2.Start();
                say2--;
                label4.Text = say2 + " saniye bekleyiniz!!!";
                button1.Enabled = false;
            }
            if (say2 == 0)
            {
                timer2.Stop();
                button1.Enabled = true;
            }
        }
        //---------------------------TİMER'IN FORMA İNTERVAL YAZIMI------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; timer2.Interval = 1000;
        }
    }
}
