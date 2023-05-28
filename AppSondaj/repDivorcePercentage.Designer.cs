namespace AppSondaj
{
    partial class repDivorcePercentage
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
            this.gridDivorce = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.divorcePercentage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDivorce)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDivorce
            // 
            this.gridDivorce.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridDivorce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDivorce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridDivorce.Location = new System.Drawing.Point(0, 75);
            this.gridDivorce.Name = "gridDivorce";
            this.gridDivorce.ReadOnly = true;
            this.gridDivorce.Size = new System.Drawing.Size(1259, 526);
            this.gridDivorce.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procentul persoanelor divortate: ";
            // 
            // divorcePercentage
            // 
            this.divorcePercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.divorcePercentage.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divorcePercentage.ForeColor = System.Drawing.SystemColors.Window;
            this.divorcePercentage.Location = new System.Drawing.Point(433, 23);
            this.divorcePercentage.Multiline = true;
            this.divorcePercentage.Name = "divorcePercentage";
            this.divorcePercentage.ReadOnly = true;
            this.divorcePercentage.Size = new System.Drawing.Size(154, 33);
            this.divorcePercentage.TabIndex = 32;
            // 
            // repDivorcePercentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1259, 601);
            this.Controls.Add(this.divorcePercentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDivorce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "repDivorcePercentage";
            this.Text = "repDivorcePercentage";
            this.Load += new System.EventHandler(this.repDivorcePercentage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDivorce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridDivorce;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox divorcePercentage;
    }
}