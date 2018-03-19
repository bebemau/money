namespace MoneyWin
{
    partial class frmTransfers
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboVendorFrom = new System.Windows.Forms.ComboBox();
            this.txtDateFrom = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVendorTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateTo = new System.Windows.Forms.MaskedTextBox();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.colPaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransferAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(827, 97);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(145, 36);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // cboVendorFrom
            // 
            this.cboVendorFrom.DisplayMember = "VendorName";
            this.cboVendorFrom.FormattingEnabled = true;
            this.cboVendorFrom.Location = new System.Drawing.Point(143, 37);
            this.cboVendorFrom.Name = "cboVendorFrom";
            this.cboVendorFrom.Size = new System.Drawing.Size(277, 32);
            this.cboVendorFrom.TabIndex = 0;
            this.cboVendorFrom.ValueMember = "VendorID";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(143, 104);
            this.txtDateFrom.Mask = "00/00/0000";
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(130, 29);
            this.txtDateFrom.TabIndex = 2;
            this.txtDateFrom.ValidatingType = typeof(System.DateTime);
            this.txtDateFrom.Enter += new System.EventHandler(this.txtDateFrom_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // cboVendorTo
            // 
            this.cboVendorTo.DisplayMember = "VendorName";
            this.cboVendorTo.FormattingEnabled = true;
            this.cboVendorTo.Location = new System.Drawing.Point(510, 37);
            this.cboVendorTo.Name = "cboVendorTo";
            this.cboVendorTo.Size = new System.Drawing.Size(294, 32);
            this.cboVendorTo.TabIndex = 1;
            this.cboVendorTo.ValueMember = "VendorID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(304, 104);
            this.txtDateTo.Mask = "00/00/0000";
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(155, 29);
            this.txtDateTo.TabIndex = 3;
            this.txtDateTo.ValidatingType = typeof(System.DateTime);
            this.txtDateTo.Enter += new System.EventHandler(this.txtDateTo_Enter);
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaymentID,
            this.colPaymentDate,
            this.colBankID,
            this.colCCBank,
            this.colBankName,
            this.colCCBankName,
            this.colPaymentDescription,
            this.colTransferAmount,
            this.colTransactionID,
            this.colBillID,
            this.colType});
            this.dgResults.Location = new System.Drawing.Point(33, 173);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowTemplate.Height = 31;
            this.dgResults.Size = new System.Drawing.Size(2218, 931);
            this.dgResults.TabIndex = 9;
            this.dgResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransactions_CellContentClick);
            // 
            // colPaymentID
            // 
            this.colPaymentID.DataPropertyName = "PaymentID";
            this.colPaymentID.HeaderText = "PaymentID";
            this.colPaymentID.Name = "colPaymentID";
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.DataPropertyName = "PaymentDate";
            this.colPaymentDate.HeaderText = "PaymentDate";
            this.colPaymentDate.Name = "colPaymentDate";
            // 
            // colBankID
            // 
            this.colBankID.DataPropertyName = "BankID";
            this.colBankID.HeaderText = "BankID";
            this.colBankID.Name = "colBankID";
            // 
            // colCCBank
            // 
            this.colCCBank.DataPropertyName = "CCBank";
            this.colCCBank.HeaderText = "CCBank";
            this.colCCBank.Name = "colCCBank";
            // 
            // colBankName
            // 
            this.colBankName.DataPropertyName = "BankName";
            this.colBankName.HeaderText = "BankName";
            this.colBankName.Name = "colBankName";
            // 
            // colCCBankName
            // 
            this.colCCBankName.DataPropertyName = "CCBankName";
            this.colCCBankName.HeaderText = "CCBankName";
            this.colCCBankName.Name = "colCCBankName";
            // 
            // colPaymentDescription
            // 
            this.colPaymentDescription.DataPropertyName = "PaymentDescription";
            this.colPaymentDescription.HeaderText = "PaymentDescription";
            this.colPaymentDescription.Name = "colPaymentDescription";
            // 
            // colTransferAmount
            // 
            this.colTransferAmount.DataPropertyName = "TransferAmount";
            this.colTransferAmount.HeaderText = "Amount";
            this.colTransferAmount.Name = "colTransferAmount";
            // 
            // colTransactionID
            // 
            this.colTransactionID.DataPropertyName = "TransactionID";
            this.colTransactionID.HeaderText = "TransactionID";
            this.colTransactionID.Name = "colTransactionID";
            // 
            // colBillID
            // 
            this.colBillID.DataPropertyName = "BillID";
            this.colBillID.HeaderText = "BillID";
            this.colBillID.Name = "colBillID";
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            // 
            // frmTransfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2354, 1116);
            this.Controls.Add(this.dgResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.cboVendorTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.cboVendorFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilter);
            this.Name = "frmTransfers";
            this.Text = "frmTransfers";
            this.Load += new System.EventHandler(this.frmTransfers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboVendorFrom;
        private System.Windows.Forms.MaskedTextBox txtDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVendorTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDateTo;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    }
}