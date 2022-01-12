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
        // item serverstring is stored here. this is the connectionstring to the database.

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
                // open a connection to the database
                SqlConnection cn = new SqlConnection(ServerString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();

                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    if (txtPassword.Text == "ADMIN" || txtUsername.Text == "ADMIN") //prevents users from making an ADMIN account
                    {
                        MessageBox.Show("CANNOT CREATE AN ADMIN ACCOUNT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        frmReg f1 = new frmReg();
                        f1.ShowDialog();
                        this.Close(); //refreshes the page
                    }
                    if (txtPassword.Text == "admin" || txtUsername.Text == "admin") //prevents users from making an ADMIN account
                    {
                        MessageBox.Show("CANNOT CREATE AN ADMIN ACCOUNT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        frmReg f1 = new frmReg();
                        f1.ShowDialog();
                        this.Close(); //refreshes the page
                    }

                    //SQL command
                    cmd = new SqlCommand("select * from Customers where username='" + txtUsername.Text + "'", cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    //start the reader

                    if (reader.Read())
                    {
                        reader.Close(); // if reader has found a username in the database
                        MessageBox.Show("Username Already taken please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else //if reader hasn't found that username in the database
                    {
                        reader.Close();
                        cmd = new SqlCommand("insert into Customers values(@username,@password)", cn); //inserts the users details in the database
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information); // final message
                    }
                }
                else
                {
                    MessageBox.Show("Please enter matching passwords", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // passwords dont match
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //text boxes are blank
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // once the login button has been clicked, open the sign in page
            this.Hide();
            FrmSignin f1 = new FrmSignin();
            f1.ShowDialog();
            this.Close();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
