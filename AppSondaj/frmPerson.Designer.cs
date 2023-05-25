namespace AppSondaj
{
    partial class frmPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.usrName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usrSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usrStudies = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usrEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.usrBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.usrJudet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.usrMunicipiu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.usrOras = new System.Windows.Forms.ComboBox();
            this.usrMarried = new System.Windows.Forms.CheckBox();
            this.usrDivorced = new System.Windows.Forms.CheckBox();
            this.usrParticipated = new System.Windows.Forms.CheckBox();
            this.usrM = new System.Windows.Forms.RadioButton();
            this.usrF = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 14;
            this.btnClose.Location = new System.Drawing.Point(601, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // usrName
            // 
            this.usrName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrName.ForeColor = System.Drawing.SystemColors.Window;
            this.usrName.Location = new System.Drawing.Point(26, 74);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(277, 29);
            this.usrName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenume";
            // 
            // usrSurname
            // 
            this.usrSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrSurname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrSurname.ForeColor = System.Drawing.SystemColors.Window;
            this.usrSurname.Location = new System.Drawing.Point(337, 74);
            this.usrSurname.Name = "usrSurname";
            this.usrSurname.Size = new System.Drawing.Size(264, 29);
            this.usrSurname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sex :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(297, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Studii";
            // 
            // usrStudies
            // 
            this.usrStudies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrStudies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrStudies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrStudies.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrStudies.ForeColor = System.Drawing.Color.White;
            this.usrStudies.FormattingEnabled = true;
            this.usrStudies.Items.AddRange(new object[] {
            "Licenta",
            "Masterat",
            "Doctorat",
            "Diploma de absolvire",
            "Cursuri postuniversitare",
            "Scoala profesionala",
            "Scoala tehnica",
            "Scoala de meserii",
            "Formare profesionala",
            "Certificare",
            "Autoeducatie"});
            this.usrStudies.Location = new System.Drawing.Point(357, 131);
            this.usrStudies.Name = "usrStudies";
            this.usrStudies.Size = new System.Drawing.Size(243, 29);
            this.usrStudies.TabIndex = 7;
            this.usrStudies.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email :";
            // 
            // usrEmail
            // 
            this.usrEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.usrEmail.Location = new System.Drawing.Point(89, 191);
            this.usrEmail.Name = "usrEmail";
            this.usrEmail.Size = new System.Drawing.Size(512, 29);
            this.usrEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Nasterii";
            // 
            // usrBirthday
            // 
            this.usrBirthday.CustomFormat = "dd.MM.yyyy";
            this.usrBirthday.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.usrBirthday.Location = new System.Drawing.Point(138, 244);
            this.usrBirthday.Name = "usrBirthday";
            this.usrBirthday.Size = new System.Drawing.Size(125, 29);
            this.usrBirthday.TabIndex = 12;
            this.usrBirthday.Value = new System.DateTime(2023, 6, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Judet";
            // 
            // usrJudet
            // 
            this.usrJudet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrJudet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrJudet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrJudet.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrJudet.ForeColor = System.Drawing.Color.White;
            this.usrJudet.FormattingEnabled = true;
            this.usrJudet.Location = new System.Drawing.Point(89, 298);
            this.usrJudet.Name = "usrJudet";
            this.usrJudet.Size = new System.Drawing.Size(190, 29);
            this.usrJudet.TabIndex = 13;
            this.usrJudet.UseWaitCursor = true;
            this.usrJudet.SelectedIndexChanged += new System.EventHandler(this.usrJudet_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(307, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Municipiu";
            // 
            // usrMunicipiu
            // 
            this.usrMunicipiu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrMunicipiu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrMunicipiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrMunicipiu.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrMunicipiu.ForeColor = System.Drawing.Color.White;
            this.usrMunicipiu.FormattingEnabled = true;
            this.usrMunicipiu.Location = new System.Drawing.Point(401, 298);
            this.usrMunicipiu.Name = "usrMunicipiu";
            this.usrMunicipiu.Size = new System.Drawing.Size(200, 29);
            this.usrMunicipiu.TabIndex = 15;
            this.usrMunicipiu.UseWaitCursor = true;
            this.usrMunicipiu.SelectedIndexChanged += new System.EventHandler(this.usrMunicipiu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Oras";
            // 
            // usrOras
            // 
            this.usrOras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrOras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrOras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrOras.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrOras.ForeColor = System.Drawing.Color.White;
            this.usrOras.FormattingEnabled = true;
            this.usrOras.Location = new System.Drawing.Point(89, 345);
            this.usrOras.Name = "usrOras";
            this.usrOras.Size = new System.Drawing.Size(190, 29);
            this.usrOras.TabIndex = 17;
            this.usrOras.UseWaitCursor = true;
            // 
            // usrMarried
            // 
            this.usrMarried.AutoSize = true;
            this.usrMarried.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrMarried.ForeColor = System.Drawing.Color.White;
            this.usrMarried.Location = new System.Drawing.Point(29, 409);
            this.usrMarried.Name = "usrMarried";
            this.usrMarried.Size = new System.Drawing.Size(118, 25);
            this.usrMarried.TabIndex = 19;
            this.usrMarried.Text = "Casatorit(a)";
            this.usrMarried.UseVisualStyleBackColor = true;
            // 
            // usrDivorced
            // 
            this.usrDivorced.AutoSize = true;
            this.usrDivorced.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrDivorced.ForeColor = System.Drawing.Color.White;
            this.usrDivorced.Location = new System.Drawing.Point(190, 409);
            this.usrDivorced.Name = "usrDivorced";
            this.usrDivorced.Size = new System.Drawing.Size(113, 25);
            this.usrDivorced.TabIndex = 20;
            this.usrDivorced.Text = "Divortat(a)";
            this.usrDivorced.UseVisualStyleBackColor = true;
            // 
            // usrParticipated
            // 
            this.usrParticipated.AutoSize = true;
            this.usrParticipated.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrParticipated.ForeColor = System.Drawing.Color.White;
            this.usrParticipated.Location = new System.Drawing.Point(357, 409);
            this.usrParticipated.Name = "usrParticipated";
            this.usrParticipated.Size = new System.Drawing.Size(118, 25);
            this.usrParticipated.TabIndex = 21;
            this.usrParticipated.Text = "A participat";
            this.usrParticipated.UseVisualStyleBackColor = true;
            // 
            // usrM
            // 
            this.usrM.AutoSize = true;
            this.usrM.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrM.ForeColor = System.Drawing.Color.White;
            this.usrM.Location = new System.Drawing.Point(76, 135);
            this.usrM.Name = "usrM";
            this.usrM.Size = new System.Drawing.Size(81, 21);
            this.usrM.TabIndex = 23;
            this.usrM.Text = "Masculin";
            this.usrM.UseVisualStyleBackColor = true;
            // 
            // usrF
            // 
            this.usrF.AutoSize = true;
            this.usrF.Checked = true;
            this.usrF.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrF.ForeColor = System.Drawing.Color.White;
            this.usrF.Location = new System.Drawing.Point(163, 135);
            this.usrF.Name = "usrF";
            this.usrF.Size = new System.Drawing.Size(76, 21);
            this.usrF.TabIndex = 24;
            this.usrF.TabStop = true;
            this.usrF.Text = "Feminin";
            this.usrF.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::AppSondaj.Properties.Resources.update;
            this.btnUpdate.Location = new System.Drawing.Point(482, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 51);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::AppSondaj.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(482, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 51);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 23);
            this.btnMinimize.TabIndex = 0;
            // 
            // frmPerson
            // 
            this.AccessibleName = "";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(640, 518);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.usrF);
            this.Controls.Add(this.usrM);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.usrParticipated);
            this.Controls.Add(this.usrDivorced);
            this.Controls.Add(this.usrMarried);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.usrOras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.usrMunicipiu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usrJudet);
            this.Controls.Add(this.usrBirthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usrEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usrStudies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usrSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People menu";
            this.Load += new System.EventHandler(this.newPerson_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        public System.Windows.Forms.TextBox usrName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox usrSurname;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox usrStudies;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox usrEmail;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker usrBirthday;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox usrJudet;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox usrMunicipiu;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox usrOras;
        public System.Windows.Forms.CheckBox usrMarried;
        public System.Windows.Forms.CheckBox usrDivorced;
        public System.Windows.Forms.CheckBox usrParticipated;
        public System.Windows.Forms.RadioButton usrM;
        public System.Windows.Forms.RadioButton usrF;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
    }
}