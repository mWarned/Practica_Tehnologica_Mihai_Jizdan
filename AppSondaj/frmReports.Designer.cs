namespace AppSondaj
{
    partial class frmReports
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.persoaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divorcedPercentageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menWithHigherEducationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleBornInGivenMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malesFemalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marriedAndOlderThan20YoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleThatRefusedToParticipateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.pollDBDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersoanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pollDBDataSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersoanaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.persoaneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // persoaneToolStripMenuItem
            // 
            this.persoaneToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.persoaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.divorcedPercentageToolStripMenuItem,
            this.menWithHigherEducationToolStripMenuItem,
            this.peopleBornInGivenMonthToolStripMenuItem,
            this.malesFemalesToolStripMenuItem,
            this.marriedAndOlderThan20YoToolStripMenuItem,
            this.peopleThatRefusedToParticipateToolStripMenuItem});
            this.persoaneToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.persoaneToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.persoaneToolStripMenuItem.Name = "persoaneToolStripMenuItem";
            this.persoaneToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.persoaneToolStripMenuItem.Text = "People";
            // 
            // divorcedPercentageToolStripMenuItem
            // 
            this.divorcedPercentageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.divorcedPercentageToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divorcedPercentageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.divorcedPercentageToolStripMenuItem.Name = "divorcedPercentageToolStripMenuItem";
            this.divorcedPercentageToolStripMenuItem.Size = new System.Drawing.Size(490, 24);
            this.divorcedPercentageToolStripMenuItem.Text = "Divorced percentage";
            this.divorcedPercentageToolStripMenuItem.Click += new System.EventHandler(this.divorcedPercentageToolStripMenuItem_Click);
            // 
            // menWithHigherEducationToolStripMenuItem
            // 
            this.menWithHigherEducationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.menWithHigherEducationToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menWithHigherEducationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.menWithHigherEducationToolStripMenuItem.Name = "menWithHigherEducationToolStripMenuItem";
            this.menWithHigherEducationToolStripMenuItem.Size = new System.Drawing.Size(490, 24);
            this.menWithHigherEducationToolStripMenuItem.Text = "Unmarried men with higher education in given age range";
            this.menWithHigherEducationToolStripMenuItem.Click += new System.EventHandler(this.menWithHigherEducationToolStripMenuItem_Click);
            // 
            // peopleBornInGivenMonthToolStripMenuItem
            // 
            this.peopleBornInGivenMonthToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.peopleBornInGivenMonthToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.peopleBornInGivenMonthToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.peopleBornInGivenMonthToolStripMenuItem.Name = "peopleBornInGivenMonthToolStripMenuItem";
            this.peopleBornInGivenMonthToolStripMenuItem.Size = new System.Drawing.Size(490, 24);
            this.peopleBornInGivenMonthToolStripMenuItem.Text = "People born in given month";
            this.peopleBornInGivenMonthToolStripMenuItem.Click += new System.EventHandler(this.peopleBornInGivenMonthToolStripMenuItem_Click);
            // 
            // malesFemalesToolStripMenuItem
            // 
            this.malesFemalesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.malesFemalesToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.malesFemalesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.malesFemalesToolStripMenuItem.Name = "malesFemalesToolStripMenuItem";
            this.malesFemalesToolStripMenuItem.Size = new System.Drawing.Size(490, 24);
            this.malesFemalesToolStripMenuItem.Text = "Males / Females with age under 18";
            this.malesFemalesToolStripMenuItem.Click += new System.EventHandler(this.malesFemalesToolStripMenuItem_Click);
            // 
            // marriedAndOlderThan20YoToolStripMenuItem
            // 
            this.marriedAndOlderThan20YoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.marriedAndOlderThan20YoToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marriedAndOlderThan20YoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.marriedAndOlderThan20YoToolStripMenuItem.Name = "marriedAndOlderThan20YoToolStripMenuItem";
            this.marriedAndOlderThan20YoToolStripMenuItem.Size = new System.Drawing.Size(490, 24);
            this.marriedAndOlderThan20YoToolStripMenuItem.Text = "Married and age over 20";
            this.marriedAndOlderThan20YoToolStripMenuItem.Click += new System.EventHandler(this.marriedAndOlderThan20YoToolStripMenuItem_Click);
            // 
            // peopleThatRefusedToParticipateToolStripMenuItem
            // 
            this.peopleThatRefusedToParticipateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.peopleThatRefusedToParticipateToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.peopleThatRefusedToParticipateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.peopleThatRefusedToParticipateToolStripMenuItem.Name = "peopleThatRefusedToParticipateToolStripMenuItem";
            this.peopleThatRefusedToParticipateToolStripMenuItem.Size = new System.Drawing.Size(490, 24);
            this.peopleThatRefusedToParticipateToolStripMenuItem.Text = "People that refused to participate";
            this.peopleThatRefusedToParticipateToolStripMenuItem.Click += new System.EventHandler(this.peopleThatRefusedToParticipateToolStripMenuItem_Click);
            // 
            // pnlReport
            // 
            this.pnlReport.Location = new System.Drawing.Point(0, 30);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(1259, 601);
            this.pnlReport.TabIndex = 1;
            this.pnlReport.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReport_Paint);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1259, 632);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pollDBDataSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersoanaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem persoaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divorcedPercentageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menWithHigherEducationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleBornInGivenMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malesFemalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marriedAndOlderThan20YoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleThatRefusedToParticipateToolStripMenuItem;
        private System.Windows.Forms.BindingSource pollDBDataSourceBindingSource;
        private System.Windows.Forms.BindingSource PersoanaBindingSource;
        private System.Windows.Forms.Panel pnlReport;
    }
}