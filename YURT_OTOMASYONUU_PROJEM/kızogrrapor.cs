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
    public partial class kızogrrapor : Form
    {
        public kızogrrapor()
        {
            InitializeComponent();
        }

        private void kızogrrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurt_otomasyon_projemDataSet3.kızogr' table. You can move, or remove it, as needed.
            this.kızogrTableAdapter.Fill(this.yurt_otomasyon_projemDataSet3.kızogr);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            erkekraporlama ker = new erkekraporlama();
            this.Hide();
            ker.Show();
        }
    }
}
