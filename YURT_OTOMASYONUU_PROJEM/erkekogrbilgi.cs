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
    public partial class textoda : Form
    {
        public textoda()
        {
            InitializeComponent();
        }        
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS; Initial Catalog=yurt_otomasyon_projem;Integrated Security=True");  
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from erkekogr", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void textsil()
        {
            textad.Clear();
            combadres.ResetText();
            combbol.ResetText();
            comboBox2.ResetText();
            textsoyad.Clear();
            textmail.Clear();
            masktc.Clear();
            masktel.Clear();
            comboda.ResetText();
        }
        private void erkekogrbilgi_Load(object sender, EventArgs e)
        {
            //ERKEK ODA 

            baglanti.Open();
            SqlCommand komuta = new SqlCommand("select Oda_No from ErkekOda where Oda_Kapasite != Oda_Aktif", baglanti);
            SqlDataReader okuma = komuta.ExecuteReader();
            while (okuma.Read())
            {
                comboda.Items.Add(okuma[0].ToString());
            }
            baglanti.Close();
           
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
             baglanti.Open();
          
            int yaş;
            yaş = int.Parse(comboBox2.Text);
            yaş = 2018 - int.Parse(comboBox2.Text);
            SqlCommand komut = new SqlCommand("insert into erkekogr values('" + textad.Text + "','" + textsoyad.Text + "','"+comboda.Text+"','" + masktc.Text + "','" + masktel.Text + "','" + int.Parse(comboBox2.Text) + "','" + yaş + "','" + combbol.Text + "','" + textmail.Text + "','" + combadres.Text + "')", baglanti);
            SqlCommand komutt = new SqlCommand("update ErkekOda set Oda_Aktif=Oda_Aktif+1 where Oda_No='"+comboda.Text+"'",baglanti);
            komutt.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            textsil();
            listele();     
           
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarıyla Tamamlandı!!!");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yaptınız");
            }
         
         
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update erkekogr set Soyad='" + textsoyad.Text + "',Oda_No='"+comboda.Text+"',Tc='" + masktc.Text + "',Tel_No='" + masktel.Text + "',Doğum_Tarihi='" + int.Parse(comboBox2.Text) + "',Bölüm='" + combbol.Text + "',Mail='" + textmail.Text + "',Adres='" + combadres.Text + "'where Ad='" + textad.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            textsil();
            listele();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı!!!");
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
            SqlCommand komut = new SqlCommand("delete from erkekogr where Tc='" + masktc.Text + "'", baglanti);
            SqlCommand komutt = new SqlCommand("update ErkekOda set Oda_Aktif=Oda_Aktif-1 where Oda_No='" + comboda.Text + "'", baglanti);
            komutt.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            textsil();
            listele();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı!!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı İşlem Yaptınız!!!");
            }
          
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter komut = new SqlDataAdapter("select * from erkekogr where Ad like  '" + textBox1.Text + "'", baglanti);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            dataGridView1.DataSource = dt;
            textsil();
            textBox1.Clear();
                 
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Bulunamadı!!!");
              
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdad.Checked)
            {
                SqlDataAdapter komut = new SqlDataAdapter(" select*from erkekogr order by Ad ", baglanti);
                DataTable dt = new DataTable();
                komut.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (rdyas.Checked)
            {
                SqlDataAdapter komut = new SqlDataAdapter(" select*from erkekogr order by Yaşı ", baglanti);
                DataTable dt = new DataTable();
                komut.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (rdbolum.Checked)
            {
                SqlDataAdapter komut = new SqlDataAdapter(" select*from erkekogr order by Bölüm ", baglanti);
                DataTable dt = new DataTable();
                komut.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri a = new kayıt_işlemleri();
            this.Hide();
            a.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string soyad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string no = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string tc = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string tel = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string dogtar = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string bol = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string mail = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
            string adres = dataGridView1.Rows[secilialan].Cells[9].Value.ToString();

            textad.Text = ad;
            textsoyad.Text = soyad;
            masktc.Text = tc;
            masktel.Text = tel;
            comboBox2.Text = dogtar;
            combbol.Text = bol;
            textmail.Text = mail;
            combadres.Text = adres;
            comboda.Text = no;
        }

        private void comboda_MouseClick(object sender, MouseEventArgs e)
        {
      
        }

        private void comboda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
