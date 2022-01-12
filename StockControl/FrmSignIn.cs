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
            // connect to my azure database
            string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cn.Open();
            //connection should have been made

            if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                // check if text boxes are empty
                cmd = new SqlCommand("select * from Customers where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                //start the reader, this reads items in an sql database
                if (txtPassword.Text == "ADMIN" || txtUsername.Text == "ADMIN")  // if the username and passwords are ADMIN allow the user to log into an admin account
                {
                    MessageBox.Show("LOGIN SUCCESSFUL");
                    reader.Close();
                    this.Hide();
                    FrmStockControl f1 = new FrmStockControl();
                    f1.ShowDialog();
                    this.Close();
                }
                if (!reader.Read())  // if the reader cannot find an account in the system with the username or password
                {
                    reader.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {   // the username and password are inside of the database, logs into the account and sent to form home.
                    MessageBox.Show("LOGIN SUCCESSFUL");
                    reader.Close();
                    this.Hide();
                    FrmHome f1 = new FrmHome();
                    f1.ShowDialog();
                    this.Close();
                }
            }
            else //box/box's are empty
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void FrmSignin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        { // once a user has clicked. they will be sent to the registation page
            this.Hide();
            frmReg f1 = new frmReg();
            f1.ShowDialog();
            this.Close();
        }
    }
}
