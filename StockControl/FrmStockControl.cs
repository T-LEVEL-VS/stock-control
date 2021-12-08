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
    public partial class FrmStockControl : Form
    {




        public const string ServerString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public FrmStockControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            int Qty;
            string ProductDesc;
            decimal Cost;







            Qty = Convert.ToInt32(txtQty.Text);
            ProductDesc = Convert.ToString(txtProdDescription.Text);
            Cost = Convert.ToDecimal(txtCost.Text);



            //string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



            SqlConnection cn = new SqlConnection(ServerString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;



            cmd.CommandText = "INSERT into Products (Quantity, ProductName, Cost) VALUES (@Qty, @ProductName, @Cost)";
            cmd.Parameters.AddWithValue("@Qty", Qty);
            cmd.Parameters.AddWithValue("@ProductName", ProductDesc);
            cmd.Parameters.AddWithValue("@Cost", Cost);



            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("added record");
        }

        private void txtProdDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(txtId.Text);

            //string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



            SqlConnection cn = new SqlConnection(ServerString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;



            cmd.CommandText = "DELETE FROM Products WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", ID);


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();


            MessageBox.Show("Deleted record ID");
        }

        private void btnUpID_Click(object sender, EventArgs e)
        {
            int UpID;
            int Qty;
            string ProductDesc;
            decimal Cost;

            UpID = Convert.ToInt32(txtId.Text);
            Qty = Convert.ToInt32(txtQty.Text);
            ProductDesc = Convert.ToString(txtProdDescription.Text);
            Cost = Convert.ToDecimal(txtCost.Text);

            //string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



            SqlConnection cn = new SqlConnection(ServerString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;



            cmd.CommandText = "UPDATE Products SET ProductName = @ProductName , Quantity = @Qty , Cost = @Cost  WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", UpID);
            cmd.Parameters.AddWithValue("@Qty", Qty);
            cmd.Parameters.AddWithValue("@ProductName", ProductDesc);
            cmd.Parameters.AddWithValue("@Cost", Cost);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();


            MessageBox.Show("Updated record ID");
        }

        private void BtnViewRec_Click(object sender, EventArgs e)
        {
            {
                //string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                {
                    int ID;
                    IDataRecord r;

                    ID = Convert.ToInt32(txtId.Text);

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
                            txtProdDescription.Text = r[1].ToString();
                            txtQty.Text = r[2].ToString();
                            txtCost.Text = r[3].ToString();
                        }
                        reader.Close(); //github change
                    }
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                //string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                {
                    int ID;
                    int Qty;

                    Qty = Convert.ToInt32(txtQty.Text);
                    ID = Convert.ToInt32(txtId.Text);


                    using (SqlConnection connection =
                    new SqlConnection(ServerString))
                    {
                        SqlConnection cn = new SqlConnection(ServerString);
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = cn;

                        cmd.CommandText = "UPDATE Products SET Quantity = @Qty WHERE ID = @ID";
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@Qty", Qty);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();


                        MessageBox.Show("Product Stock Changed");
                    }
                }

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            {
                //string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                {
                    int ID;
                    int OutOfStock;

                    ID = Convert.ToInt32(txtId.Text);
                    OutOfStock = 0;

                    using (SqlConnection connection =
                    new SqlConnection(ServerString))
                    {
                        SqlConnection cn = new SqlConnection(ServerString);
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = cn;

                        cmd.CommandText = "UPDATE Products SET Quantity = @Qty WHERE ID = @ID";
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@Qty",OutOfStock);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();


                        MessageBox.Show("Product Out Of Stock");
                    }
                }

            }
        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtHowMany_TextChanged(object sender, EventArgs e)
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            {
                //string connectionString = "Server=tcp:jkf2331659.database.windows.net,1433;Initial Catalog=StockControl;Persist Security Info=False;User ID=JKF2331659;Password=Barnsley123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


                //int ID;
                //int Bought;
                //int NewNumber;

                //int StockLevel;
                //IDataRecord r;


                //ID = Convert.ToInt32(txtName.Text);
                //Bought = Convert.ToInt32(txtUser.Text);
                {
                    //string queryString =
                    //"SELECT * FROM Products WHERE ID = @ID";

                    //using (SqlConnection connection =
                    //new SqlConnection(ServerString))
                    // {
                    //SqlCommand command =
                    //new SqlCommand(queryString, connection);
                    //command.Parameters.AddWithValue("@ID", ID);
                    //connection.Open();

                    //SqlDataReader reader = command.ExecuteReader();

                    //while (reader.Read())
                    {
                        // r = reader;
                        //int c = 0;
                        //txtProdName.Text = r[1].ToString();

                        ///txtHowMany.Text = r[2].ToString();

                        //txtHowMany.Text = r[2].ToString();

                        //txtHowMany.Text = c;
                        //c = (int)c - Bought;

                        //MessageBox.Show((string)c);

                        //txtPrice.Text = r[3].ToString();
                    }
                        // reader.Close();

                        MessageBox.Show("Product Purchased");
                 
                }

            }
        }
    }
}
