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
    public partial class FrmCustomer : Form
    {

        public const string ServerString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                //string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                {
                    int ID;
                    IDataRecord r;

                    ID = Convert.ToInt32(txtName.Text);

                    string queryString =
                   "SELECT * FROM Products WHERE ID = @ID";

                    using (SqlConnection connection =
                    new SqlConnection(ServerString))
                    {
                        SqlCommand command =
                        new SqlCommand(queryString, connection);
                        command.Parameters.AddWithValue("@ID", ID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            r = reader;
                            txtProdName.Text = r[1].ToString();
                            txtHowMany.Text = r[2].ToString();
                            txtPrice.Text = r[3].ToString();
                        }
                        reader.Close();
                    }
                }

            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


                int ID;
                int Bought;
                int NewNumber;

                int StockLevel;
                IDataRecord r;


                ID = Convert.ToInt32(txtName.Text);
                Bought = Convert.ToInt32(txtUser.Text);
                {
                    string queryString =
                    "SELECT * FROM Products WHERE ID = @ID";

                    using (SqlConnection connection =
                    new SqlConnection(ServerString))
                    {
                        SqlCommand command =
                        new SqlCommand(queryString, connection);
                        command.Parameters.AddWithValue("@ID", ID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            r = reader;
                            int c = 0;
                            txtProdName.Text = r[1].ToString();

                            txtHowMany.Text = r[2].ToString();

                            txtHowMany.Text = r[2].ToString();

                            //txtHowMany.Text = c;
                            c = (int)c - Bought;

                            //MessageBox.Show((string)c);

                            txtPrice.Text = r[3].ToString();
                        }
                        reader.Close();

                        MessageBox.Show("Product Purchased");
                    }
                }

            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
