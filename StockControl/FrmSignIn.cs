using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class FrmSignin : Form
    {
        public FrmSignin()
        {
            InitializeComponent();
        }

        private void BtnSignIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome f1 = new FrmHome();
            f1.ShowDialog();
            this.Close();
        }

        private void FrmSignin_Load(object sender, EventArgs e)
        {

        }
    }
}
