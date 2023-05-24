namespace AppSondaj
{
    partial class newAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newAnswer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.usrPerson = new System.Windows.Forms.ComboBox();
            this.usrTheme = new System.Windows.Forms.ComboBox();
            this.usrQuestion = new System.Windows.Forms.ComboBox();
            this.usrAnswer = new System.Windows.Forms.TextBox();
            this.usrQuestionLong = new System.Windows.Forms.TextBox();
            this.usrLanguage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 31);
            this.panel1.TabIndex = 4;
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
            this.btnExit.Location = new System.Drawing.Point(622, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Persoana";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tematica";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Intrebarea";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Raspunsul";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::AppSondaj.Properties.Resources.update;
            this.btnUpdate.Location = new System.Drawing.Point(504, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 50);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::AppSondaj.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(504, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 50);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // usrPerson
            // 
            this.usrPerson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrPerson.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrPerson.ForeColor = System.Drawing.Color.White;
            this.usrPerson.FormattingEnabled = true;
            this.usrPerson.Location = new System.Drawing.Point(178, 59);
            this.usrPerson.Name = "usrPerson";
            this.usrPerson.Size = new System.Drawing.Size(297, 29);
            this.usrPerson.TabIndex = 31;
            this.usrPerson.UseWaitCursor = true;
            // 
            // usrTheme
            // 
            this.usrTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrTheme.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrTheme.ForeColor = System.Drawing.Color.White;
            this.usrTheme.FormattingEnabled = true;
            this.usrTheme.Location = new System.Drawing.Point(178, 104);
            this.usrTheme.Name = "usrTheme";
            this.usrTheme.Size = new System.Drawing.Size(297, 29);
            this.usrTheme.TabIndex = 32;
            this.usrTheme.UseWaitCursor = true;
            this.usrTheme.SelectedIndexChanged += new System.EventHandler(this.usrTheme_SelectedIndexChanged);
            // 
            // usrQuestion
            // 
            this.usrQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrQuestion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrQuestion.ForeColor = System.Drawing.Color.White;
            this.usrQuestion.FormattingEnabled = true;
            this.usrQuestion.Location = new System.Drawing.Point(178, 149);
            this.usrQuestion.Name = "usrQuestion";
            this.usrQuestion.Size = new System.Drawing.Size(297, 29);
            this.usrQuestion.TabIndex = 33;
            this.usrQuestion.UseWaitCursor = true;
            this.usrQuestion.SelectedIndexChanged += new System.EventHandler(this.usrQuestion_SelectedIndexChanged);
            // 
            // usrAnswer
            // 
            this.usrAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrAnswer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrAnswer.ForeColor = System.Drawing.SystemColors.Window;
            this.usrAnswer.Location = new System.Drawing.Point(178, 298);
            this.usrAnswer.Multiline = true;
            this.usrAnswer.Name = "usrAnswer";
            this.usrAnswer.Size = new System.Drawing.Size(434, 97);
            this.usrAnswer.TabIndex = 34;
            // 
            // usrQuestionLong
            // 
            this.usrQuestionLong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrQuestionLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrQuestionLong.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrQuestionLong.ForeColor = System.Drawing.SystemColors.Window;
            this.usrQuestionLong.Location = new System.Drawing.Point(178, 184);
            this.usrQuestionLong.Multiline = true;
            this.usrQuestionLong.Name = "usrQuestionLong";
            this.usrQuestionLong.Size = new System.Drawing.Size(434, 94);
            this.usrQuestionLong.TabIndex = 35;
            // 
            // usrLanguage
            // 
            this.usrLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrLanguage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLanguage.ForeColor = System.Drawing.Color.White;
            this.usrLanguage.FormattingEnabled = true;
            this.usrLanguage.Location = new System.Drawing.Point(178, 419);
            this.usrLanguage.Name = "usrLanguage";
            this.usrLanguage.Size = new System.Drawing.Size(297, 29);
            this.usrLanguage.TabIndex = 37;
            this.usrLanguage.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Limba";
            // 
            // newAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(661, 522);
            this.Controls.Add(this.usrLanguage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usrQuestionLong);
            this.Controls.Add(this.usrAnswer);
            this.Controls.Add(this.usrQuestion);
            this.Controls.Add(this.usrTheme);
            this.Controls.Add(this.usrPerson);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newPoll";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox usrPerson;
        public System.Windows.Forms.ComboBox usrTheme;
        public System.Windows.Forms.ComboBox usrQuestion;
        public System.Windows.Forms.TextBox usrAnswer;
        public System.Windows.Forms.TextBox usrQuestionLong;
        public System.Windows.Forms.ComboBox usrLanguage;
        private System.Windows.Forms.Label label5;
    }
}