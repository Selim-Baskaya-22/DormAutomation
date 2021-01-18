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
    public partial class ErkekSilOgrl : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS; Initial Catalog=yurt_otomasyon_projem;Integrated Security=True");  
   
        public ErkekSilOgrl()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from silinenmüşteriler",baglanti);                                
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri ay = new kayıt_işlemleri();
            this.Hide();
            ay.Show();
        }

  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            textBox1.Text = ad;
        }

        private void ErkekSilOgrl_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from silinenmüşteriler where Tc='"+textBox1.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
            textBox1.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı İşlem Yaptınız!!!");
            }
             
        }
       
    }
}
