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
    public partial class yedekleme : Form
    {
        public yedekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=USER-BILGISAYAR\\SQLEXPRESS; Initial Catalog=yurt_otomasyon_projem;Integrated Security=True");  
 

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string database = baglantı.Database.ToString();
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("lütfen yedek dosya konumunu girin");
                }
                else
                {

                    string cmd = "BACKUP DATABASE[" + database + "] TO DISK= '" + textBox1.Text + "\\" + textBox2.Text + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    using (SqlCommand command = new SqlCommand(cmd, baglantı))
                    {
                        if (baglantı.State != ConnectionState.Open)
                        {
                            baglantı.Open();

                        }
                        command.ExecuteNonQuery();
                        baglantı.Close();
                        MessageBox.Show("Database Yedekleme Başarılı!!! ");
                        button1.Enabled = false;

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
               
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Veri Tabanı Geri Yükleme";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = dlg.FileName;
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string database = baglantı.Database.ToString();
            if (baglantı.State != ConnectionState.Open)
            {
                baglantı.Open();
            }
            try
            {

                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, baglantı);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox3.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, baglantı);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, baglantı);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Database Geri Yükleme Başarılı!!");
                baglantı.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri KAS = new kayıt_işlemleri();
            this.Hide();
            KAS.Show();
        }
    }
}
