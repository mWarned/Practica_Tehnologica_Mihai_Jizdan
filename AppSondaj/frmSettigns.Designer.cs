namespace AppSondaj
{
    partial class frmSettigns
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
            this.grActions = new System.Windows.Forms.GroupBox();
            this.grTheme = new System.Windows.Forms.GroupBox();
            this.usrThBlue = new System.Windows.Forms.RadioButton();
            this.usrThLight = new System.Windows.Forms.RadioButton();
            this.usrThDark = new System.Windows.Forms.RadioButton();
            this.lblTheme = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAccList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grActions.SuspendLayout();
            this.grTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grActions
            // 
            this.grActions.Controls.Add(this.btnAccList);
            this.grActions.Controls.Add(this.btnAdd);
            this.grActions.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.grActions.ForeColor = System.Drawing.Color.White;
            this.grActions.Location = new System.Drawing.Point(964, 22);
            this.grActions.Name = "grActions";
            this.grActions.Size = new System.Drawing.Size(259, 502);
            this.grActions.TabIndex = 5;
            this.grActions.TabStop = false;
            this.grActions.Text = "Users Actions";
            // 
            // grTheme
            // 
            this.grTheme.Controls.Add(this.pictureBox3);
            this.grTheme.Controls.Add(this.pictureBox2);
            this.grTheme.Controls.Add(this.pictureBox1);
            this.grTheme.Controls.Add(this.usrThBlue);
            this.grTheme.Controls.Add(this.usrThLight);
            this.grTheme.Controls.Add(this.usrThDark);
            this.grTheme.Controls.Add(this.lblTheme);
            this.grTheme.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.grTheme.ForeColor = System.Drawing.Color.White;
            this.grTheme.Location = new System.Drawing.Point(40, 22);
            this.grTheme.Name = "grTheme";
            this.grTheme.Size = new System.Drawing.Size(880, 251);
            this.grTheme.TabIndex = 8;
            this.grTheme.TabStop = false;
            this.grTheme.Text = "Customisation";
            // 
            // usrThBlue
            // 
            this.usrThBlue.AutoSize = true;
            this.usrThBlue.Location = new System.Drawing.Point(724, 188);
            this.usrThBlue.Name = "usrThBlue";
            this.usrThBlue.Size = new System.Drawing.Size(62, 25);
            this.usrThBlue.TabIndex = 3;
            this.usrThBlue.Text = "Blue";
            this.usrThBlue.UseVisualStyleBackColor = true;
            this.usrThBlue.CheckedChanged += new System.EventHandler(this.usrThBlue_CheckedChanged);
            // 
            // usrThLight
            // 
            this.usrThLight.AutoSize = true;
            this.usrThLight.Location = new System.Drawing.Point(422, 188);
            this.usrThLight.Name = "usrThLight";
            this.usrThLight.Size = new System.Drawing.Size(67, 25);
            this.usrThLight.TabIndex = 2;
            this.usrThLight.Text = "Light";
            this.usrThLight.UseVisualStyleBackColor = true;
            this.usrThLight.CheckedChanged += new System.EventHandler(this.usrThLight_CheckedChanged);
            // 
            // usrThDark
            // 
            this.usrThDark.AutoSize = true;
            this.usrThDark.Location = new System.Drawing.Point(109, 188);
            this.usrThDark.Name = "usrThDark";
            this.usrThDark.Size = new System.Drawing.Size(64, 25);
            this.usrThDark.TabIndex = 1;
            this.usrThDark.Text = "Dark";
            this.usrThDark.UseVisualStyleBackColor = true;
            this.usrThDark.CheckedChanged += new System.EventHandler(this.usrThDark_CheckedChanged);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.lblTheme.Location = new System.Drawing.Point(25, 47);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(169, 30);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Chose a theme :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppSondaj.Properties.Resources.ThemeBlue;
            this.pictureBox3.Location = new System.Drawing.Point(676, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 92);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppSondaj.Properties.Resources.ThemeLight;
            this.pictureBox2.Location = new System.Drawing.Point(377, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 92);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSondaj.Properties.Resources.ThemeDark;
            this.pictureBox1.Location = new System.Drawing.Point(73, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 92);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAccList
            // 
            this.btnAccList.FlatAppearance.BorderSize = 0;
            this.btnAccList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccList.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnAccList.Image = global::AppSondaj.Properties.Resources.list;
            this.btnAccList.Location = new System.Drawing.Point(15, 116);
            this.btnAccList.Name = "btnAccList";
            this.btnAccList.Size = new System.Drawing.Size(226, 66);
            this.btnAccList.TabIndex = 7;
            this.btnAccList.Text = "View users list";
            this.btnAccList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAccList.UseVisualStyleBackColor = true;
            this.btnAccList.Click += new System.EventHandler(this.btnAccList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnAdd.Image = global::AppSondaj.Properties.Resources._new;
            this.btnAdd.Location = new System.Drawing.Point(15, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 66);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add new user";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSettigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1275, 671);
            this.Controls.Add(this.grTheme);
            this.Controls.Add(this.grActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettigns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.grActions.ResumeLayout(false);
            this.grTheme.ResumeLayout(false);
            this.grTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grActions;
        private System.Windows.Forms.GroupBox grTheme;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton usrThBlue;
        private System.Windows.Forms.RadioButton usrThLight;
        private System.Windows.Forms.RadioButton usrThDark;
        private System.Windows.Forms.Label lblTheme;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnAccList;
    }
}