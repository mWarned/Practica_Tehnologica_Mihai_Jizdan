namespace AppSondaj
{
    partial class peopleEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(peopleEdit));
            this.gridPeople = new System.Windows.Forms.DataGridView();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.pnlSideBtn = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeople)).BeginInit();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPeople
            // 
            this.gridPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.gridPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeople.Location = new System.Drawing.Point(12, 12);
            this.gridPeople.Name = "gridPeople";
            this.gridPeople.ReadOnly = true;
            this.gridPeople.Size = new System.Drawing.Size(998, 647);
            this.gridPeople.TabIndex = 8;
            // 
            // grpActions
            // 
            this.grpActions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpActions.Controls.Add(this.pnlSideBtn);
            this.grpActions.Controls.Add(this.btnDelete);
            this.grpActions.Controls.Add(this.btnAdd);
            this.grpActions.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.ForeColor = System.Drawing.Color.White;
            this.grpActions.Location = new System.Drawing.Point(1025, 12);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(238, 647);
            this.grpActions.TabIndex = 9;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // pnlSideBtn
            // 
            this.pnlSideBtn.Location = new System.Drawing.Point(225, 31);
            this.pnlSideBtn.Name = "pnlSideBtn";
            this.pnlSideBtn.Size = new System.Drawing.Size(7, 66);
            this.pnlSideBtn.TabIndex = 4;
            this.pnlSideBtn.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnDelete.Image = global::AppSondaj.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(6, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(226, 66);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeletePpl_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnAdd.Image = global::AppSondaj.Properties.Resources._new;
            this.btnAdd.Location = new System.Drawing.Point(6, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 66);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddPpl_Click);
            // 
            // peopleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1275, 671);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.gridPeople);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "peopleEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "peopleEdit";
            this.Load += new System.EventHandler(this.peopleEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPeople)).EndInit();
            this.grpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPeople;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Panel pnlSideBtn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}