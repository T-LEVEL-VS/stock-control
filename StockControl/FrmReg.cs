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
    public partial class frmReg : Form
    {

        public const string ServerString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public frmReg()
        {
            InitializeComponent();
        }

        private void frmReg_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignIN_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != string.Empty || txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                SqlConnection cn = new SqlConnection(ServerString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    if (txtPassword.Text == "ADMIN" || txtUsername.Text == "ADMIN")
                    {
                        MessageBox.Show("CANNOT CREATE AN ADMIN ACCOUNT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        frmReg f1 = new frmReg();
                        f1.ShowDialog();
                        this.Close();
                    }
                    if (txtPassword.Text == "admin" || txtUsername.Text == "admin")
                    {
                        MessageBox.Show("CANNOT CREATE AN ADMIN ACCOUNT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        frmReg f1 = new frmReg();
                        f1.ShowDialog();
                        this.Close();
                    }
                    cmd = new SqlCommand("select * from Customers where username='" + txtUsername.Text + "'", cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Username Already exists please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        reader.Close();
                        cmd = new SqlCommand("insert into Customers values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both passwords the same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignin f1 = new FrmSignin();
            f1.ShowDialog();
            this.Close();
        }
    }
}
