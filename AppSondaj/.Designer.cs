namespace AppSondaj
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlSideBtn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.btnPoll = new System.Windows.Forms.Button();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnThemesQuestions = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.usrImg = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.pnlActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usrImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlActions.Controls.Add(this.btnThemesQuestions);
            this.pnlActions.Controls.Add(this.btnPeople);
            this.pnlActions.Controls.Add(this.btnReports);
            this.pnlActions.Controls.Add(this.pnlSideBtn);
            this.pnlActions.Controls.Add(this.btnPoll);
            this.pnlActions.Controls.Add(this.btnLogin);
            this.pnlActions.Controls.Add(this.btnSettings);
            this.pnlActions.Controls.Add(this.panel1);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlActions.Location = new System.Drawing.Point(0, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(225, 700);
            this.pnlActions.TabIndex = 0;
            // 
            // pnlSideBtn
            // 
            this.pnlSideBtn.Location = new System.Drawing.Point(3, 508);
            this.pnlSideBtn.Name = "pnlSideBtn";
            this.pnlSideBtn.Size = new System.Drawing.Size(7, 56);
            this.pnlSideBtn.TabIndex = 4;
            this.pnlSideBtn.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlUser);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.imgUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 152);
            this.panel1.TabIndex = 0;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Controls.Add(this.usrImg);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(225, 152);
            this.pnlUser.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.lblUser.Location = new System.Drawing.Point(36, 100);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(152, 35);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.lblUsername.Location = new System.Drawing.Point(64, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlUp.Controls.Add(this.btnMinimize);
            this.pnlUp.Controls.Add(this.btnExit);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(225, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1275, 29);
            this.pnlUp.TabIndex = 1;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDesktop.Location = new System.Drawing.Point(225, 29);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1275, 671);
            this.pnlDesktop.TabIndex = 2;
            // 
            // btnPoll
            // 
            this.btnPoll.FlatAppearance.BorderSize = 0;
            this.btnPoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoll.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnPoll.Image = global::AppSondaj.Properties.Resources.edit;
            this.btnPoll.Location = new System.Drawing.Point(0, 231);
            this.btnPoll.Name = "btnPoll";
            this.btnPoll.Size = new System.Drawing.Size(225, 56);
            this.btnPoll.TabIndex = 1;
            this.btnPoll.Text = "Edit Polls";
            this.btnPoll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPoll.UseVisualStyleBackColor = true;
            this.btnPoll.Click += new System.EventHandler(this.btnPoll_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 14;
            this.btnMinimize.Location = new System.Drawing.Point(1202, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 29);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 14;
            this.btnExit.Location = new System.Drawing.Point(1240, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThemesQuestions
            // 
            this.btnThemesQuestions.FlatAppearance.BorderSize = 0;
            this.btnThemesQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemesQuestions.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemesQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnThemesQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemesQuestions.Image")));
            this.btnThemesQuestions.Location = new System.Drawing.Point(0, 293);
            this.btnThemesQuestions.Name = "btnThemesQuestions";
            this.btnThemesQuestions.Size = new System.Drawing.Size(225, 56);
            this.btnThemesQuestions.TabIndex = 2;
            this.btnThemesQuestions.Text = "Themes/Questions";
            this.btnThemesQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThemesQuestions.UseVisualStyleBackColor = true;
            this.btnThemesQuestions.Click += new System.EventHandler(this.btnThemesQuestions_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnPeople.Image")));
            this.btnPeople.Location = new System.Drawing.Point(0, 169);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(225, 56);
            this.btnPeople.TabIndex = 0;
            this.btnPeople.Text = "People List";
            this.btnPeople.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.Location = new System.Drawing.Point(0, 355);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(225, 56);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(0, 632);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(225, 56);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log out";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 570);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(225, 56);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // usrImg
            // 
            this.usrImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usrImg.Image = ((System.Drawing.Image)(resources.GetObject("usrImg.Image")));
            this.usrImg.Location = new System.Drawing.Point(65, 18);
            this.usrImg.Name = "usrImg";
            this.usrImg.Size = new System.Drawing.Size(90, 79);
            this.usrImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usrImg.TabIndex = 0;
            this.usrImg.TabStop = false;
            this.usrImg.Click += new System.EventHandler(this.usrImg_Click);
            // 
            // imgUser
            // 
            this.imgUser.Location = new System.Drawing.Point(0, 0);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(100, 50);
            this.imgUser.TabIndex = 3;
            this.imgUser.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1500, 700);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlUp);
            this.Controls.Add(this.pnlActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poll App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlActions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usrImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Button btnPoll;
        private System.Windows.Forms.Panel pnlSideBtn;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox usrImg;
        private System.Windows.Forms.Panel pnlUp;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnThemesQuestions;
        public System.Windows.Forms.Label lblUser;
    }
}

