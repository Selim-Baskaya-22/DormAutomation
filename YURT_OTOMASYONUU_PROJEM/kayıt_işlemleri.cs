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
    public partial class kayıt_işlemleri : Form
    {
        public kayıt_işlemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textoda er = new textoda();
            this.Hide();
            er.Show();
        }
       private void button2_Click(object sender, EventArgs e)
        {
            erkekvelibilgi ve = new erkekvelibilgi();
            this.Hide();
            ve.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            kızogrbilgi kız = new kızogrbilgi();
            this.Hide();
            kız.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            kızvelibilgi k = new kızvelibilgi();
            this.Hide();
            k.Show();
        }
   

        private void button6_Click(object sender, EventArgs e)
        {
            erkeködeme s = new erkeködeme();
            this.Hide();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kızödeme kız = new kızödeme();
            this.Hide();
            kız.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            erkekraporlama er = new erkekraporlama();
            this.Hide();
            er.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ErkekSilOgrl sil = new ErkekSilOgrl();
            this.Hide();
            sil.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KızOgrSil sile = new KızOgrSil();
            this.Hide();
            sile.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Gider_Tablosu g = new Gider_Tablosu();
            this.Hide();
            g.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Yurt_Gelir y = new Yurt_Gelir();
            this.Hide();
            y.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Okul_Tanıımı ok = new Okul_Tanıımı();
            this.Hide();
            ok.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Oda_Durum_Kontrol oda = new Oda_Durum_Kontrol();
            this.Hide();
            oda.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Oda_Durumu_Raporla rapo = new Oda_Durumu_Raporla();
            this.Hide();
            rapo.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Oda_Durumu_Raporla_ERKEK_ ER = new Oda_Durumu_Raporla_ERKEK_();
            this.Hide();
            ER.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            yedekleme y = new yedekleme();
            this.Hide();
            y.Show();
        }


    }
}
