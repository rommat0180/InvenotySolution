namespace Inventory
{
    partial class SignIn
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
            this.SigninBtn = new System.Windows.Forms.Button();
            this.SignInHeadingLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SigninBtn
            // 
            this.SigninBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SigninBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SigninBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninBtn.Location = new System.Drawing.Point(287, 253);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(75, 31);
            this.SigninBtn.TabIndex = 0;
            this.SigninBtn.Text = "Signin";
            this.SigninBtn.UseVisualStyleBackColor = true;
            this.SigninBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignInHeadingLbl
            // 
            this.SignInHeadingLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInHeadingLbl.AutoSize = true;
            this.SignInHeadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInHeadingLbl.Location = new System.Drawing.Point(284, 41);
            this.SignInHeadingLbl.Name = "SignInHeadingLbl";
            this.SignInHeadingLbl.Size = new System.Drawing.Size(98, 31);
            this.SignInHeadingLbl.TabIndex = 1;
            this.SignInHeadingLbl.Text = "Sign In";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(290, 125);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(296, 23);
            this.UsernameTxt.TabIndex = 2;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(198, 131);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(77, 17);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username:";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(202, 199);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(73, 17);
            this.PasswordLbl.TabIndex = 6;
            this.PasswordLbl.Text = "Password:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(290, 193);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(296, 23);
            this.PasswordTxt.TabIndex = 5;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(796, 367);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.SignInHeadingLbl);
            this.Controls.Add(this.SigninBtn);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SigninBtn;
        private System.Windows.Forms.Label SignInHeadingLbl;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
    }
}