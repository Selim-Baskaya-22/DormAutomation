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
    public partial class kızvelrapor : Form
    {
        public kızvelrapor()
        {
            InitializeComponent();
        }

        private void kızvelrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurt_otomasyon_projemDataSet4.kızvel' table. You can move, or remove it, as needed.
            this.kızvelTableAdapter.Fill(this.yurt_otomasyon_projemDataSet4.kızvel);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            erkekraporlama keri = new erkekraporlama();
            this.Hide();
            keri.Show();
        }
    }
}
