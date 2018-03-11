namespace MoneyWin
{
    partial class frmVendors
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
            this.txtSearchVendor = new System.Windows.Forms.TextBox();
            this.dgVendors = new System.Windows.Forms.DataGridView();
            this.colVendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsBank = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Vendor";
            // 
            // txtSearchVendor
            // 
            this.txtSearchVendor.Location = new System.Drawing.Point(312, 46);
            this.txtSearchVendor.Name = "txtSearchVendor";
            this.txtSearchVendor.Size = new System.Drawing.Size(414, 29);
            this.txtSearchVendor.TabIndex = 1;
            this.txtSearchVendor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchVendor_OnKeyDown);
            // 
            // dgVendors
            // 
            this.dgVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVendorID,
            this.colVendorName,
            this.colIsBank,
            this.colIsActive});
            this.dgVendors.Location = new System.Drawing.Point(48, 98);
            this.dgVendors.Name = "dgVendors";
            this.dgVendors.RowTemplate.Height = 31;
            this.dgVendors.Size = new System.Drawing.Size(1185, 850);
            this.dgVendors.TabIndex = 2;
            // 
            // colVendorID
            // 
            this.colVendorID.DataPropertyName = "VendorID";
            this.colVendorID.HeaderText = "VendorID";
            this.colVendorID.Name = "colVendorID";
            // 
            // colVendorName
            // 
            this.colVendorName.DataPropertyName = "VendorName";
            this.colVendorName.HeaderText = "VendorName";
            this.colVendorName.Name = "colVendorName";
            // 
            // colIsBank
            // 
            this.colIsBank.DataPropertyName = "IsBank";
            this.colIsBank.HeaderText = "IsBank";
            this.colIsBank.Name = "colIsBank";
            this.colIsBank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsBank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "Active";
            this.colIsActive.HeaderText = "IsActive";
            this.colIsActive.Name = "colIsActive";
            // 
            // frmVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 976);
            this.Controls.Add(this.dgVendors);
            this.Controls.Add(this.txtSearchVendor);
            this.Controls.Add(this.label1);
            this.Name = "frmVendors";
            this.Text = "frmVendors";
            this.Load += new System.EventHandler(this.frmVendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchVendor;
        private System.Windows.Forms.DataGridView dgVendors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendorName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsBank;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
    }
}