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
    public partial class Okul_Tanıımı : Form
    {
        public Okul_Tanıımı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıt_işlemleri k = new kayıt_işlemleri();
            this.Hide();
            k.Show();
        }

        private void Okul_Tanıımı_Load(object sender, EventArgs e)
        {

        }
    }
}
