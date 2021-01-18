using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YURT_OTOMASYONUU_PROJEM
{
    public partial class Yurt_Gelir : Form
    {
        public Yurt_Gelir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS; Initial Catalog=yurt_otomasyon_projem;Integrated Security=True");

        private void Yurt_Gelir_Load(object sender, EventArgs e)
        {
            //erkek kasa toplam tutar
                baglanti.Open();
                SqlCommand komut=new SqlCommand("select SUM(Ödenen) from erkeködeme ",baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label3.Text = oku[0].ToString()+" TL";
                }
                baglanti.Close();
            //erkek ögr tekrarsız olarak aylar gelsin
                baglanti.Open();
                SqlCommand kon = new SqlCommand("Select distinct(Ödenen_Ay) from erkeködeme", baglanti);
                SqlDataReader ku = kon.ExecuteReader();
                while (ku.Read())
                {
                    comboBox1.Items.Add(ku[0].ToString());
                }
                baglanti.Close();
            //kız kasa toplam tutar
                baglanti.Open();
                SqlCommand k=new SqlCommand("select SUM(Ödenen) from kızödeme ",baglanti);
                SqlDataReader ok = k.ExecuteReader();
                while (ok.Read())
                {
                    label9.Text = ok[0].ToString()+" TL";
                }
                baglanti.Close();
                //kız ögr tekrarsız olarak aylar gelsin
                baglanti.Open();
                SqlCommand konu = new SqlCommand("Select distinct(Ödenen_Ay) from kızödeme", baglanti);
                SqlDataReader kuu = konu.ExecuteReader();
                while (kuu.Read())
                {
                    comboBox2.Items.Add(kuu[0].ToString());
                }
                baglanti.Close();
            //erkek istatatisik
                baglanti.Open();
                SqlCommand komm = new SqlCommand("select Ödenen_Ay,Ödenen from erkeködeme",baglanti);
                SqlDataReader okuu = komm.ExecuteReader();
                while (okuu.Read())
                {
                    chart1.Series["Ödenen"].Points.AddXY(okuu[0].ToString(), okuu[1].ToString());
                }
                baglanti.Close(); 
            //kız istatatisik
                baglanti.Open();
                SqlCommand kız = new SqlCommand("select Ödenen_Ay,Ödenen from kızödeme",baglanti);
                SqlDataReader okuz = kız.ExecuteReader();
                while (okuz.Read())
                {
                    chart2.Series["Ödenenn"].Points.AddXY(okuz[0].ToString(), okuz[1].ToString());
                }
                baglanti.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri ka = new kayıt_işlemleri();
            this.Hide();
            ka.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ödenen) from erkeködeme where Ödenen_Ay='" + comboBox1.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label11.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ödenen) from kızödeme where Ödenen_Ay='" + comboBox2.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label12.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
    }
}
