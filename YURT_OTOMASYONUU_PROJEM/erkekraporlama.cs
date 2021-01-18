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
    public partial class erkekraporlama : Form
    {
        public erkekraporlama()
        {
            InitializeComponent();
        }

        private void erkekraporlama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            erkekogrrapor la = new erkekogrrapor();
            this.Hide();
            la.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            erkekvelrapor ve = new erkekvelrapor();
            this.Hide();
            ve.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri si=new kayıt_işlemleri();
            this.Hide();
            si.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            erkeködemerapor sda = new erkeködemerapor();
            this.Hide();
            sda.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kızogrrapor kız = new kızogrrapor();
            this.Hide();
            kız.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kızvelrapor irek = new kızvelrapor();
            this.Hide();
            irek.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kızödemerapor ırk = new kızödemerapor();
            this.Hide();
            ırk.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            yurtgiderrapor y = new yurtgiderrapor();
            this.Hide();
            y.Show();
        }

      
    }
}
