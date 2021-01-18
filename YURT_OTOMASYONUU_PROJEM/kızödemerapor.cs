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
    public partial class kızödemerapor : Form
    {
        public kızödemerapor()
        {
            InitializeComponent();
        }

        private void kızödemerapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurt_otomasyon_projemDataSet8.kızödeme' table. You can move, or remove it, as needed.
            this.kızödemeTableAdapter.Fill(this.yurt_otomasyon_projemDataSet8.kızödeme);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            erkekraporlama kır = new erkekraporlama();
            this.Hide();
            kır.Show();
        }
    }
}
