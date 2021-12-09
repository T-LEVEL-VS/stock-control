using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            string Username;
            string Password;

            Username = Convert.ToString(txtUsername.Text);
            Password = Convert.ToString(txtPassword.Text);

            string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;

            cmd.CommandText = "INSERT into Customers (Username, Password) VALUES (@Username,@Password)";
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Username", Username);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            this.Hide();
            FrmHome f1 = new FrmHome();
            f1.ShowDialog();
            this.Close();

            MessageBox.Show("LOGIN SUCCESSFUL");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
