
namespace StockControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblProdDes = new System.Windows.Forms.Label();
            this.txtProdDescription = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCosts = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnID = new System.Windows.Forms.Button();
            this.btnUpID = new System.Windows.Forms.Button();
            this.BtnViewRec = new System.Windows.Forms.Button();
            this.btnInStock = new System.Windows.Forms.Button();
            this.btnOutStock = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtHowMany = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(0, 67);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 23);
            this.txtQty.TabIndex = 2;
            this.txtQty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(0, 28);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 15);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "Qty";
            this.lblQty.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblProdDes
            // 
            this.lblProdDes.AutoSize = true;
            this.lblProdDes.Location = new System.Drawing.Point(147, 28);
            this.lblProdDes.Name = "lblProdDes";
            this.lblProdDes.Size = new System.Drawing.Size(67, 15);
            this.lblProdDes.TabIndex = 4;
            this.lblProdDes.Text = "Description";
            this.lblProdDes.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtProdDescription
            // 
            this.txtProdDescription.Location = new System.Drawing.Point(147, 67);
            this.txtProdDescription.Name = "txtProdDescription";
            this.txtProdDescription.Size = new System.Drawing.Size(100, 23);
            this.txtProdDescription.TabIndex = 5;
            this.txtProdDescription.TextChanged += new System.EventHandler(this.txtProdDescription_TextChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(320, -97);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 15);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(298, 67);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(101, 23);
            this.txtCost.TabIndex = 7;
            // 
            // lblCosts
            // 
            this.lblCosts.AutoSize = true;
            this.lblCosts.Location = new System.Drawing.Point(298, 28);
            this.lblCosts.Name = "lblCosts";
            this.lblCosts.Size = new System.Drawing.Size(31, 15);
            this.lblCosts.TabIndex = 8;
            this.lblCosts.Text = "Cost";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(493, 67);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(97, 23);
            this.btnAddRecord.TabIndex = 9;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(0, 351);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID";
            this.lblId.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(0, 369);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(106, 23);
            this.txtId.TabIndex = 11;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(477, 332);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(100, 23);
            this.btnID.TabIndex = 12;
            this.btnID.Text = "Delete record";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpID
            // 
            this.btnUpID.Location = new System.Drawing.Point(247, 393);
            this.btnUpID.Name = "btnUpID";
            this.btnUpID.Size = new System.Drawing.Size(101, 23);
            this.btnUpID.TabIndex = 13;
            this.btnUpID.Text = "Update Record";
            this.btnUpID.UseVisualStyleBackColor = true;
            this.btnUpID.Click += new System.EventHandler(this.btnUpID_Click);
            // 
            // BtnViewRec
            // 
            this.BtnViewRec.Location = new System.Drawing.Point(442, 469);
            this.BtnViewRec.Name = "BtnViewRec";
            this.BtnViewRec.Size = new System.Drawing.Size(97, 23);
            this.BtnViewRec.TabIndex = 14;
            this.BtnViewRec.Text = "View Record";
            this.BtnViewRec.UseVisualStyleBackColor = true;
            this.BtnViewRec.Click += new System.EventHandler(this.BtnViewRec_Click);
            // 
            // btnInStock
            // 
            this.btnInStock.Location = new System.Drawing.Point(196, 332);
            this.btnInStock.Name = "btnInStock";
            this.btnInStock.Size = new System.Drawing.Size(97, 23);
            this.btnInStock.TabIndex = 15;
            this.btnInStock.Text = "In Stock";
            this.btnInStock.UseVisualStyleBackColor = true;
            this.btnInStock.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOutStock
            // 
            this.btnOutStock.Location = new System.Drawing.Point(335, 332);
            this.btnOutStock.Name = "btnOutStock";
            this.btnOutStock.Size = new System.Drawing.Size(97, 23);
            this.btnOutStock.TabIndex = 16;
            this.btnOutStock.Text = "Out of Stock";
            this.btnOutStock.UseVisualStyleBackColor = true;
            this.btnOutStock.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(869, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1011, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(1047, 332);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 23);
            this.btnBuy.TabIndex = 25;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1011, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtHowMany
            // 
            this.txtHowMany.Location = new System.Drawing.Point(814, 213);
            this.txtHowMany.Name = "txtHowMany";
            this.txtHowMany.Size = new System.Drawing.Size(100, 23);
            this.txtHowMany.TabIndex = 27;
            this.txtHowMany.TextChanged += new System.EventHandler(this.txtHowMany_TextChanged);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(950, 213);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 23);
            this.txtProdName.TabIndex = 28;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(1099, 213);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 29;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(814, 195);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 15);
            this.lblStock.TabIndex = 30;
            this.lblStock.Text = "In Stock";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(950, 195);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(84, 15);
            this.lblProdName.TabIndex = 31;
            this.lblProdName.Text = "Product Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(1099, 195);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "Price";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(857, 332);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 23);
            this.txtUser.TabIndex = 33;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(857, 314);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 15);
            this.lblUser.TabIndex = 34;
            this.lblUser.Text = "Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 786);
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
            this.Controls.Add(this.btnOutStock);
            this.Controls.Add(this.btnInStock);
            this.Controls.Add(this.BtnViewRec);
            this.Controls.Add(this.btnUpID);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.lblCosts);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtProdDescription);
            this.Controls.Add(this.lblProdDes);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblProdDes;
        private System.Windows.Forms.TextBox txtProdDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCosts;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnUpID;
        private System.Windows.Forms.Button BtnViewRec;
        private System.Windows.Forms.Button btnInStock;
        private System.Windows.Forms.Button btnOutStock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtHowMany;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
    }
}

