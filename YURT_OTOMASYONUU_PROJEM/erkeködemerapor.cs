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
    public partial class erkeködemerapor : Form
    {
        public erkeködemerapor()
        {
            InitializeComponent();
        }

        private void erkeködemerapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurt_otomasyon_projemDataSet7.erkeködeme' table. You can move, or remove it, as needed.
            this.erkeködemeTableAdapter.Fill(this.yurt_otomasyon_projemDataSet7.erkeködeme);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            erkekraporlama asd = new erkekraporlama();
            this.Show();
            asd.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            erkekraporlama ke = new erkekraporlama();
            this.Hide();
            ke.Show();
        }
    }
}
