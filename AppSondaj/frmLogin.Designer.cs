namespace AppSondaj
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlUp = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.underline1 = new System.Windows.Forms.Panel();
            this.underline2 = new System.Windows.Forms.Panel();
            this.usrPass = new System.Windows.Forms.TextBox();
            this.usrLogin = new System.Windows.Forms.TextBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnViewPass = new FontAwesome.Sharp.IconButton();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            this.imgUsername = new System.Windows.Forms.PictureBox();
            this.imgLock = new System.Windows.Forms.PictureBox();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlUp.Controls.Add(this.lblLogin);
            this.pnlUp.Controls.Add(this.btnExit);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(373, 31);
            this.pnlUp.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblLogin.Location = new System.Drawing.Point(9, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(82, 18);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login Page";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 14;
            this.btnExit.Location = new System.Drawing.Point(336, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // underline1
            // 
            this.underline1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underline1.BackColor = System.Drawing.Color.DarkViolet;
            this.underline1.Location = new System.Drawing.Point(24, 261);
            this.underline1.Name = "underline1";
            this.underline1.Size = new System.Drawing.Size(322, 1);
            this.underline1.TabIndex = 9;
            // 
            // underline2
            // 
            this.underline2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underline2.BackColor = System.Drawing.Color.DarkViolet;
            this.underline2.Location = new System.Drawing.Point(24, 340);
            this.underline2.Name = "underline2";
            this.underline2.Size = new System.Drawing.Size(322, 1);
            this.underline2.TabIndex = 11;
            // 
            // usrPass
            // 
            this.usrPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrPass.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usrPass.ForeColor = System.Drawing.Color.DarkViolet;
            this.usrPass.Location = new System.Drawing.Point(71, 305);
            this.usrPass.Name = "usrPass";
            this.usrPass.Size = new System.Drawing.Size(240, 29);
            this.usrPass.TabIndex = 1;
            this.usrPass.UseSystemPasswordChar = true;
            // 
            // usrLogin
            // 
            this.usrLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrLogin.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usrLogin.ForeColor = System.Drawing.Color.DarkViolet;
            this.usrLogin.Location = new System.Drawing.Point(71, 226);
            this.usrLogin.Name = "usrLogin";
            this.usrLogin.Size = new System.Drawing.Size(275, 29);
            this.usrLogin.TabIndex = 0;
            // 
            // lblClear
            // 
            this.lblClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClear.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblClear.Location = new System.Drawing.Point(238, 356);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(108, 23);
            this.lblClear.TabIndex = 15;
            this.lblClear.Text = "Clear fields";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DarkViolet;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(24, 409);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(322, 49);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnViewPass
            // 
            this.btnViewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewPass.FlatAppearance.BorderSize = 0;
            this.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPass.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnViewPass.IconColor = System.Drawing.Color.DarkViolet;
            this.btnViewPass.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnViewPass.IconSize = 36;
            this.btnViewPass.Location = new System.Drawing.Point(317, 305);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(29, 29);
            this.btnViewPass.TabIndex = 17;
            this.btnViewPass.UseVisualStyleBackColor = true;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // imgPassword
            // 
            this.imgPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPassword.Image = ((System.Drawing.Image)(resources.GetObject("imgPassword.Image")));
            this.imgPassword.Location = new System.Drawing.Point(24, 305);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(41, 29);
            this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPassword.TabIndex = 12;
            this.imgPassword.TabStop = false;
            // 
            // imgUsername
            // 
            this.imgUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgUsername.Image = ((System.Drawing.Image)(resources.GetObject("imgUsername.Image")));
            this.imgUsername.Location = new System.Drawing.Point(24, 226);
            this.imgUsername.Name = "imgUsername";
            this.imgUsername.Size = new System.Drawing.Size(41, 29);
            this.imgUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsername.TabIndex = 10;
            this.imgUsername.TabStop = false;
            // 
            // imgLock
            // 
            this.imgLock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLock.Image = ((System.Drawing.Image)(resources.GetObject("imgLock.Image")));
            this.imgLock.Location = new System.Drawing.Point(118, 55);
            this.imgLock.Name = "imgLock";
            this.imgLock.Size = new System.Drawing.Size(122, 133);
            this.imgLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLock.TabIndex = 8;
            this.imgLock.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(373, 489);
            this.Controls.Add(this.btnViewPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.usrLogin);
            this.Controls.Add(this.usrPass);
            this.Controls.Add(this.imgPassword);
            this.Controls.Add(this.underline2);
            this.Controls.Add(this.imgUsername);
            this.Controls.Add(this.underline1);
            this.Controls.Add(this.imgLock);
            this.Controls.Add(this.pnlUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUp;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.PictureBox imgLock;
        private System.Windows.Forms.Panel underline1;
        private System.Windows.Forms.PictureBox imgUsername;
        private System.Windows.Forms.PictureBox imgPassword;
        private System.Windows.Forms.Panel underline2;
        private System.Windows.Forms.TextBox usrPass;
        private System.Windows.Forms.TextBox usrLogin;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Button btnLogin;
        private FontAwesome.Sharp.IconButton btnViewPass;
        private System.Windows.Forms.Label lblLogin;
    }
}