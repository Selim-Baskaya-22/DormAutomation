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
    public partial class Gider_Tablosu : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS; Initial Catalog=yurt_otomasyon_projem;Integrated Security=True");

        public Gider_Tablosu()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from gider",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void textlerisil()
        {
            textBox1.Clear();
            textelektrik.Clear();
            textdogalgaz.Clear();
            textdiger.Clear();
            textpersmaas.Clear();
            textinternet.Clear();
            textsu.Clear();
            textgıda.Clear();
        }
            private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

            private void button2_Click(object sender, EventArgs e)
            {
                try
                {
int tutar = 0;
                tutar=tutar+(int.Parse(textelektrik.Text) + int.Parse(textsu.Text) + int.Parse(textdogalgaz.Text) + int.Parse(textinternet.Text) + int.Parse(textgıda.Text) + int.Parse(textpersmaas.Text) + int.Parse(textdiger.Text));
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into gider values('"+int.Parse(textBox1.Text)+"','"+int.Parse(textelektrik.Text)+"','"+int.Parse(textsu.Text)+"','"+int.Parse(textdogalgaz.Text)+"','"+int.Parse(textinternet.Text)+"','"+int.Parse(textgıda.Text)+"','"+int.Parse(textpersmaas.Text)+"','"+int.Parse(textdiger.Text)+"','"+tutar+"') ",baglanti);
                komut.ExecuteNonQuery();
                listele();
                baglanti.Close();
                textlerisil();
                MessageBox.Show("Ekleme İşlemi Başarıyla Tamamlandı!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı İşlem Yaptınız!!!");
                }
                
            }

            private void button3_Click(object sender, EventArgs e)
            {
                try
                {
 baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from gider where Fatura_İd='"+int.Parse(textBox1.Text)+"'",baglanti);
                komut.ExecuteNonQuery();
                listele();
                baglanti.Close();
                textlerisil(); MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı İşlem Yaptınız!!!");
                }
               

            }

            private void button4_Click(object sender, EventArgs e)
            {
                try
                {
int tutar = 0;
                tutar = tutar + (int.Parse(textelektrik.Text) + int.Parse(textsu.Text) + int.Parse(textdogalgaz.Text) + int.Parse(textinternet.Text) + int.Parse(textgıda.Text) + int.Parse(textpersmaas.Text) + int.Parse(textdiger.Text));
              
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update gider set Elektrik='" + int.Parse(textelektrik.Text) + "',Su='" + int.Parse(textsu.Text) + "',Dogalgaz='" + int.Parse(textdogalgaz.Text) + "',İnternet='" + int.Parse(textinternet.Text) + "',Gıda='" + int.Parse(textgıda.Text) + "',Personel_Maaş='" + int.Parse(textpersmaas.Text) + "',Diğer='" + int.Parse(textdiger.Text) + "',Tutar='" + tutar + "' where Fatura_İd='"+int.Parse(textBox1.Text)+"'",baglanti);
                komut.ExecuteNonQuery();
                listele();
                baglanti.Close(); MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı İşlem Yaptınız!!!");
                }   
                

            }

            private void button5_Click(object sender, EventArgs e)
            {
                kayıt_işlemleri kas = new kayıt_işlemleri();
                this.Hide();
                kas.Show();
            }

            private void Gider_Tablosu_Load(object sender, EventArgs e)
            {

            }

    

  

     
    }
}
