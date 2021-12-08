
namespace StockControl
{
    partial class FrmSignIn
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
            this.Btn_StockControl = new System.Windows.Forms.Button();
            this.Btn_Customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_StockControl
            // 
            this.Btn_StockControl.Location = new System.Drawing.Point(289, 90);
            this.Btn_StockControl.Name = "Btn_StockControl";
            this.Btn_StockControl.Size = new System.Drawing.Size(171, 30);
            this.Btn_StockControl.TabIndex = 0;
            this.Btn_StockControl.Text = "Admin View";
            this.Btn_StockControl.UseVisualStyleBackColor = true;
            this.Btn_StockControl.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.Location = new System.Drawing.Point(289, 302);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Size = new System.Drawing.Size(171, 23);
            this.Btn_Customer.TabIndex = 1;
            this.Btn_Customer.Text = "Customer View";
            this.Btn_Customer.UseVisualStyleBackColor = true;
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // FrmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Customer);
            this.Controls.Add(this.Btn_StockControl);
            this.Name = "FrmSignIn";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_StockControl;
        private System.Windows.Forms.Button Btn_Customer;
    }
}