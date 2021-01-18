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
    public partial class kızvelibilgi : Form
    {
        public kızvelibilgi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS; Initial Catalog=yurt_otomasyon_projem;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from kızvel", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void textsil()
        {
            combograd.ResetText();
            textad.Clear();
            textsoyad.Clear();
            texttc.Clear();
            texttel.Clear();
            textadres.ResetText();
            textdogtar.ResetText();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void kızvelibilgi_Load(object sender, EventArgs e)
        {
            combograd.Items.Clear();
            SqlDataReader oku;
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select Ad from kızogr ", baglanti);
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                combograd.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kızvel values ('" + combograd.Text + "','" + textad.Text + "','" + textsoyad.Text + "','" + texttel.Text + "','" + texttc.Text + "','" + int.Parse(textdogtar.Text) + "','" + textadres.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            textsil(); MessageBox.Show("Ekleme İşlemi Başarıyla Tamamlandı!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yaptınız!!!");
            }   
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from erkekvel where Tc='" + texttc.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                textsil();
                MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yaptınız!!!");
            }
            
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
baglanti.Open();
            SqlCommand komut = new SqlCommand("update kızvel set  Ad='" + textad.Text + "',Soyad='" + textsoyad.Text + "',Tel_No='" + texttel.Text + "',Tc='" + texttc.Text + "',Doğum_Tarihi='" + textdogtar.Text + "',Adres='" + textadres.Text + "' where Öğrenci_Adı='" + combograd.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            textsil(); MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yaptınız!!!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri K = new kayıt_işlemleri();
            this.Hide();
            K.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string soyad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string tc = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string tel = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string dogtar = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string bol = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string mail = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();

            combograd.Text = ad;
            textad.Text = soyad;
            textsoyad.Text = tc;
            texttel.Text = tel;
            texttc.Text = dogtar;
            textdogtar.Text = bol;
            textadres.Text = mail;
        }
    }
}
