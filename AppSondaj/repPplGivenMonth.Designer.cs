namespace AppSondaj
{
    partial class repPplGivenMonth
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridPplGivenMonth = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.usrMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPplGivenMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 40;
            this.label1.Text = "Selectati luna:";
            // 
            // gridPplGivenMonth
            // 
            this.gridPplGivenMonth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridPplGivenMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPplGivenMonth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPplGivenMonth.Location = new System.Drawing.Point(0, 64);
            this.gridPplGivenMonth.Name = "gridPplGivenMonth";
            this.gridPplGivenMonth.ReadOnly = true;
            this.gridPplGivenMonth.Size = new System.Drawing.Size(1259, 537);
            this.gridPplGivenMonth.TabIndex = 39;
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnExcel.Image = global::AppSondaj.Properties.Resources.save;
            this.btnExcel.Location = new System.Drawing.Point(1087, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(160, 46);
            this.btnExcel.TabIndex = 45;
            this.btnExcel.Text = "Export";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // usrMonth
            // 
            this.usrMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.usrMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrMonth.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrMonth.ForeColor = System.Drawing.Color.White;
            this.usrMonth.FormattingEnabled = true;
            this.usrMonth.Items.AddRange(new object[] {
            "Ianuarie",
            "Februarie",
            "Martie",
            "Aprilie",
            "Mai",
            "Iunie",
            "Iulie",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.usrMonth.Location = new System.Drawing.Point(201, 23);
            this.usrMonth.Name = "usrMonth";
            this.usrMonth.Size = new System.Drawing.Size(121, 31);
            this.usrMonth.TabIndex = 46;
            this.usrMonth.SelectedIndexChanged += new System.EventHandler(this.usrMonth_SelectedIndexChanged);
            // 
            // repPplGivenMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1259, 601);
            this.Controls.Add(this.usrMonth);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPplGivenMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "repPplGivenMonth";
            this.Text = "repPplGivenMonth";
            ((System.ComponentModel.ISupportInitialize)(this.gridPplGivenMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPplGivenMonth;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox usrMonth;
    }
}