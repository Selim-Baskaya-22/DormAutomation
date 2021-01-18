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
    public partial class Oda_Durumu_Raporla : Form
    {
        public Oda_Durumu_Raporla()
        {
            InitializeComponent();
        }

        private void Oda_Durumu_Raporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurt_otomasyon_projemDataSet10.Oda' table. You can move, or remove it, as needed.
            this.OdaTableAdapter.Fill(this.yurt_otomasyon_projemDataSet10.Oda);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri k = new kayıt_işlemleri();
            this.Hide();
            k.Show();
        }
    }
}
