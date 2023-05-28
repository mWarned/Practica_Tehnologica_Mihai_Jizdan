namespace AppSondaj
{
    partial class repPplMarriedUnder20
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
            this.txtMarriedUnder20 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPplMarriedUnder20 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPplMarriedUnder20)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarriedUnder20
            // 
            this.txtMarriedUnder20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarriedUnder20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtMarriedUnder20.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarriedUnder20.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMarriedUnder20.Location = new System.Drawing.Point(671, 22);
            this.txtMarriedUnder20.Multiline = true;
            this.txtMarriedUnder20.Name = "txtMarriedUnder20";
            this.txtMarriedUnder20.ReadOnly = true;
            this.txtMarriedUnder20.Size = new System.Drawing.Size(106, 33);
            this.txtMarriedUnder20.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 33);
            this.label1.TabIndex = 52;
            this.label1.Text = "Numarul persoanelor casatorite cu varsta sub 20 ani";
            // 
            // gridPplMarriedUnder20
            // 
            this.gridPplMarriedUnder20.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridPplMarriedUnder20.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPplMarriedUnder20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPplMarriedUnder20.Location = new System.Drawing.Point(0, 77);
            this.gridPplMarriedUnder20.Name = "gridPplMarriedUnder20";
            this.gridPplMarriedUnder20.ReadOnly = true;
            this.gridPplMarriedUnder20.Size = new System.Drawing.Size(1259, 524);
            this.gridPplMarriedUnder20.TabIndex = 51;
            // 
            // repPplMarriedUnder20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1259, 601);
            this.Controls.Add(this.txtMarriedUnder20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPplMarriedUnder20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "repPplMarriedUnder20";
            this.Text = "repPplMarriedOver20";
            this.Load += new System.EventHandler(this.repPplMarriedOver20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPplMarriedUnder20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMarriedUnder20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPplMarriedUnder20;
    }
}