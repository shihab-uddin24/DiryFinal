﻿namespace DiryFinal
{
    partial class Login
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
            this.User = new System.Windows.Forms.Label();
            this.UsertextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.LoginDiry = new System.Windows.Forms.Button();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(143, 161);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(129, 29);
            this.User.TabIndex = 0;
            this.User.Text = "UserName";
            // 
            // UsertextBox
            // 
            this.UsertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertextBox.Location = new System.Drawing.Point(306, 158);
            this.UsertextBox.Name = "UsertextBox";
            this.UsertextBox.Size = new System.Drawing.Size(145, 34);
            this.UsertextBox.TabIndex = 1;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.Location = new System.Drawing.Point(306, 260);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(149, 34);
            this.PasswordtextBox.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(133, 265);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(120, 29);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // LoginDiry
            // 
            this.LoginDiry.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginDiry.Location = new System.Drawing.Point(269, 354);
            this.LoginDiry.Name = "LoginDiry";
            this.LoginDiry.Size = new System.Drawing.Size(149, 46);
            this.LoginDiry.TabIndex = 4;
            this.LoginDiry.Text = "Login";
            this.LoginDiry.UseVisualStyleBackColor = false;
            this.LoginDiry.Click += new System.EventHandler(this.LoginDiry_Click);
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(283, 462);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(116, 17);
            this.registerLink.TabIndex = 5;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Not register yet?!";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 565);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.LoginDiry);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UsertextBox);
            this.Controls.Add(this.User);
            this.Name = "Login";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox UsertextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button LoginDiry;
        private System.Windows.Forms.LinkLabel registerLink;
    }
}

