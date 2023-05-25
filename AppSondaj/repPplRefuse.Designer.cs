namespace AppSondaj
{
    partial class repPplRefuse
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
            this.gridPplNotTakenPart = new System.Windows.Forms.DataGridView();
            this.txtNotTakenPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPplNotTakenPart)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPplNotTakenPart
            // 
            this.gridPplNotTakenPart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.gridPplNotTakenPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPplNotTakenPart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPplNotTakenPart.Location = new System.Drawing.Point(0, 77);
            this.gridPplNotTakenPart.Name = "gridPplNotTakenPart";
            this.gridPplNotTakenPart.ReadOnly = true;
            this.gridPplNotTakenPart.Size = new System.Drawing.Size(1259, 524);
            this.gridPplNotTakenPart.TabIndex = 45;
            // 
            // txtNotTakenPart
            // 
            this.txtNotTakenPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNotTakenPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNotTakenPart.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotTakenPart.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNotTakenPart.Location = new System.Drawing.Point(533, 19);
            this.txtNotTakenPart.Multiline = true;
            this.txtNotTakenPart.Name = "txtNotTakenPart";
            this.txtNotTakenPart.ReadOnly = true;
            this.txtNotTakenPart.Size = new System.Drawing.Size(106, 33);
            this.txtNotTakenPart.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Numarul persoanelor ce nu au participat";
            // 
            // repPplRefuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1259, 601);
            this.Controls.Add(this.txtNotTakenPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPplNotTakenPart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "repPplRefuse";
            this.Text = "repPplRefude";
            this.Load += new System.EventHandler(this.repPplRefuse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPplNotTakenPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPplNotTakenPart;
        public System.Windows.Forms.TextBox txtNotTakenPart;
        private System.Windows.Forms.Label label1;
    }
}