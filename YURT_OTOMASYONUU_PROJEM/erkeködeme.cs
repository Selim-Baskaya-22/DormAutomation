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
    public partial class erkeködeme : Form
    {
        public erkeködeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS; Initial Catalog=yurt_otomasyon_projem;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT  * FROM erkeködeme", baglanti);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
            baglanti.Close();
        }
        void textsil()
        {
            combograd.ResetText();
            textodenen.Clear();
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void erkeködeme_Load(object sender, EventArgs e)
        {
           
            
            combograd.Items.Clear();
            SqlDataReader oku;
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select Ad from erkekogr ", baglanti);
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                combograd.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
            textodenmesigereken.Text = "Yıllık 3000 TL ";
            textodenmesigereken.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            int kalan = 3000;
            int ödenen = int.Parse(textodenen.Text);
            kalan = kalan - ödenen;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into erkeködeme values('" + textBox2.Text + "','" + combograd.Text + "','" + textodenmesigereken.Text + "','" + ödenen + "','" + dateTimePicker1.Text + "','" + kalan + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            textsil();
            MessageBox.Show("Ekleme İşlemi Başarıyla Tamamlandı!!!");
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from erkeködeme where Öğrenci_İd='" + textBox2.Text + "'", baglanti);
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            int kalan = 3000;
            int ödenen = int.Parse(textodenen.Text);
            kalan = kalan - ödenen;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update erkeködeme set Öğrenci_Adı='" + combograd.Text + "',Ödenen='" + int.Parse(textodenen.Text) + "',Kalan_Borç='" + kalan + "',Ödenen_Ay='" + dateTimePicker1.Text + "' where Öğrenci_İd='" + textBox2.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            listele();
            textsil();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yaptınız!!!");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("select*from erkeködeme where Öğrenci_Adı like '" + textBox1.Text + "'", baglanti);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            textBox1.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Öğrenci Bulunamadı!!!");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string soyad = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string ds = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string dsr = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            combograd.Text = ad;
           textBox2.Text=dsr;
            textodenen.Text = soyad;
            dateTimePicker1.Text = ds;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kayıt_işlemleri k = new kayıt_işlemleri();
            this.Hide();
            k.Show();
        }

        private void combograd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
