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
    public partial class Oda_Durum_Kontrol : Form
    {
        public Oda_Durum_Kontrol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS; Initial Catalog=yurt_otomasyon_projem;Integrated Security=True");

        void kız()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Oda",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void erkek()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from ErkekOda", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kız();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            erkek();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri kasa = new kayıt_işlemleri();
            this.Hide();
            kasa.Show();
        }
    }
}
