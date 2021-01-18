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
    public partial class erkekvelrapor : Form
    {
        public erkekvelrapor()
        {
            InitializeComponent();
        }

        private void erkekvelrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurt_otomasyon_projemDataSet1.erkekvel' table. You can move, or remove it, as needed.
            this.erkekvelTableAdapter.Fill(this.yurt_otomasyon_projemDataSet1.erkekvel);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            erkekraporlama k = new erkekraporlama();
            this.Hide();
            k.Show();
        }
    }
}
