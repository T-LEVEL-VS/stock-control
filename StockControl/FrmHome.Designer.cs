
namespace StockControl
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.Btn_StockControl = new System.Windows.Forms.Button();
            this.Btn_Customer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_StockControl
            // 
            this.Btn_StockControl.Location = new System.Drawing.Point(289, 221);
            this.Btn_StockControl.Name = "Btn_StockControl";
            this.Btn_StockControl.Size = new System.Drawing.Size(171, 30);
            this.Btn_StockControl.TabIndex = 0;
            this.Btn_StockControl.Text = "Admin View";
            this.Btn_StockControl.UseVisualStyleBackColor = true;
            this.Btn_StockControl.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.Location = new System.Drawing.Point(289, 280);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Size = new System.Drawing.Size(171, 30);
            this.Btn_Customer.TabIndex = 1;
            this.Btn_Customer.Text = "Customer View";
            this.Btn_Customer.UseVisualStyleBackColor = true;
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(213, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 74);
            this.label2.TabIndex = 37;
            this.label2.Text = "Home";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Welcome to the stock buying system.";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(759, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Customer);
            this.Controls.Add(this.Btn_StockControl);
            this.Name = "FrmHome";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_StockControl;
        private System.Windows.Forms.Button Btn_Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}