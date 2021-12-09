
namespace StockControl
{
    partial class FrmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtHowMany = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomerLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(86, 235);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 15);
            this.lblUser.TabIndex = 46;
            this.lblUser.Text = "Quantity";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(86, 253);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 23);
            this.txtUser.TabIndex = 45;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(332, 175);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 44;
            this.lblPrice.Text = "Price";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(86, 175);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(84, 15);
            this.lblProdName.TabIndex = 43;
            this.lblProdName.Text = "Product Name";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(212, 175);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 15);
            this.lblStock.TabIndex = 42;
            this.lblStock.Text = "In Stock";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(332, 193);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 41;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(86, 193);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 23);
            this.txtProdName.TabIndex = 40;
            // 
            // txtHowMany
            // 
            this.txtHowMany.Location = new System.Drawing.Point(212, 193);
            this.txtHowMany.Name = "txtHowMany";
            this.txtHowMany.Size = new System.Drawing.Size(100, 23);
            this.txtHowMany.TabIndex = 39;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 108);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Search";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(212, 252);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 23);
            this.btnBuy.TabIndex = 37;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 36;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(212, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 47;
            this.label1.Text = "Purchase Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCustomerLogOut
            // 
            this.btnCustomerLogOut.Location = new System.Drawing.Point(525, 314);
            this.btnCustomerLogOut.Name = "btnCustomerLogOut";
            this.btnCustomerLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerLogOut.TabIndex = 48;
            this.btnCustomerLogOut.Text = "Log Out";
            this.btnCustomerLogOut.UseVisualStyleBackColor = true;
            this.btnCustomerLogOut.Click += new System.EventHandler(this.btnCustomerLogOut_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(612, 349);
            this.Controls.Add(this.btnCustomerLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtHowMany);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmCustomer";
            this.Text = "Customer home";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtHowMany;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomerLogOut;
    }
}