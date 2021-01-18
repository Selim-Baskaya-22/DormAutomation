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
    public partial class Oda_Durumu_Raporla_ERKEK_ : Form
    {
        public Oda_Durumu_Raporla_ERKEK_()
        {
            InitializeComponent();
        }

        private void Oda_Durumu_Raporla_ERKEK__Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurt_otomasyon_projemDataSet11.ErkekOda' table. You can move, or remove it, as needed.
            this.ErkekOdaTableAdapter.Fill(this.yurt_otomasyon_projemDataSet11.ErkekOda);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri a = new kayıt_işlemleri();
            this.Hide();
            a.Show();
        }
    }
}
