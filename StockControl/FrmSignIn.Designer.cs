﻿
namespace StockControl
{
    partial class FrmSignin
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.BtnSignIN = new System.Windows.Forms.Button();
            this.Lbl_CustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(416, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(221, 191);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // BtnSignIN
            // 
            this.BtnSignIN.Location = new System.Drawing.Point(309, 275);
            this.BtnSignIN.Name = "BtnSignIN";
            this.BtnSignIN.Size = new System.Drawing.Size(96, 37);
            this.BtnSignIN.TabIndex = 2;
            this.BtnSignIN.Text = "SIGN IN";
            this.BtnSignIN.UseVisualStyleBackColor = true;
            this.BtnSignIN.Click += new System.EventHandler(this.BtnSignIN_Click);
            // 
            // Lbl_CustomerName
            // 
            this.Lbl_CustomerName.AutoSize = true;
            this.Lbl_CustomerName.Location = new System.Drawing.Point(221, 170);
            this.Lbl_CustomerName.Name = "Lbl_CustomerName";
            this.Lbl_CustomerName.Size = new System.Drawing.Size(60, 15);
            this.Lbl_CustomerName.TabIndex = 3;
            this.Lbl_CustomerName.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(193, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 79);
            this.label2.TabIndex = 38;
            this.label2.Text = "WELCOME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 430);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_CustomerName);
            this.Controls.Add(this.BtnSignIN);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Name = "FrmSignin";
            this.Text = "Sign in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button BtnSignIN;
        private System.Windows.Forms.Label Lbl_CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}