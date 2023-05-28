namespace AppSondaj
{
    partial class repMenHigherEducation
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
            this.gridMenHighEducation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.usrAge1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usrAge2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenHighEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMenHighEducation
            // 
            this.gridMenHighEducation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridMenHighEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMenHighEducation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMenHighEducation.Location = new System.Drawing.Point(0, 77);
            this.gridMenHighEducation.Name = "gridMenHighEducation";
            this.gridMenHighEducation.ReadOnly = true;
            this.gridMenHighEducation.Size = new System.Drawing.Size(1259, 524);
            this.gridMenHighEducation.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Dati diapazonul varstei:  Intre";
            // 
            // usrAge1
            // 
            this.usrAge1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrAge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrAge1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrAge1.ForeColor = System.Drawing.SystemColors.Window;
            this.usrAge1.Location = new System.Drawing.Point(378, 22);
            this.usrAge1.Multiline = true;
            this.usrAge1.Name = "usrAge1";
            this.usrAge1.Size = new System.Drawing.Size(106, 33);
            this.usrAge1.TabIndex = 47;
            this.usrAge1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usrAge1_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnSearch.Image = global::AppSondaj.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(653, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 46);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(490, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 33);
            this.label2.TabIndex = 49;
            this.label2.Text = "si";
            // 
            // usrAge2
            // 
            this.usrAge2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrAge2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrAge2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrAge2.ForeColor = System.Drawing.SystemColors.Window;
            this.usrAge2.Location = new System.Drawing.Point(532, 22);
            this.usrAge2.Multiline = true;
            this.usrAge2.Name = "usrAge2";
            this.usrAge2.Size = new System.Drawing.Size(106, 33);
            this.usrAge2.TabIndex = 50;
            this.usrAge2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usrAge2_KeyPress);
            // 
            // repMenHigherEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1259, 601);
            this.Controls.Add(this.usrAge2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.usrAge1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMenHighEducation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "repMenHigherEducation";
            this.Text = "repMenHigherEducation";
            ((System.ComponentModel.ISupportInitialize)(this.gridMenHighEducation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridMenHighEducation;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox usrAge1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox usrAge2;
    }
}