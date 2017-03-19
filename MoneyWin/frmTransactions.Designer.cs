namespace MoneyWin
{
    partial class frmTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountWithdrawal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatePosted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTransactions
            // 
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransactionID,
            this.colBankID,
            this.colVendorID,
            this.colDate,
            this.colFrom,
            this.colTo,
            this.colCheckNumber,
            this.colDeposit,
            this.colAmountWithdrawal,
            this.colTransactionType,
            this.colDescription,
            this.colDatePosted,
            this.colDateClosed,
            this.colCategoryID});
            this.dgTransactions.Location = new System.Drawing.Point(12, 244);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.ReadOnly = true;
            this.dgTransactions.RowTemplate.Height = 28;
            this.dgTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransactions.Size = new System.Drawing.Size(1733, 570);
            this.dgTransactions.TabIndex = 0;
            this.dgTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransactions_CellContentClick);
            // 
            // colTransactionID
            // 
            this.colTransactionID.DataPropertyName = "TransactionID";
            this.colTransactionID.HeaderText = "ID";
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.ReadOnly = true;
            // 
            // colBankID
            // 
            this.colBankID.DataPropertyName = "BankID";
            this.colBankID.HeaderText = "BankID";
            this.colBankID.Name = "colBankID";
            this.colBankID.ReadOnly = true;
            // 
            // colVendorID
            // 
            this.colVendorID.DataPropertyName = "VendorID";
            this.colVendorID.HeaderText = "VendorID";
            this.colVendorID.Name = "colVendorID";
            this.colVendorID.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "TransactionDate";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colFrom
            // 
            this.colFrom.DataPropertyName = "BankName";
            this.colFrom.HeaderText = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.ReadOnly = true;
            // 
            // colTo
            // 
            this.colTo.DataPropertyName = "VendorName";
            this.colTo.HeaderText = "To";
            this.colTo.Name = "colTo";
            this.colTo.ReadOnly = true;
            // 
            // colCheckNumber
            // 
            this.colCheckNumber.DataPropertyName = "CheckNumber";
            this.colCheckNumber.HeaderText = "CheckNumber";
            this.colCheckNumber.Name = "colCheckNumber";
            this.colCheckNumber.ReadOnly = true;
            // 
            // colDeposit
            // 
            this.colDeposit.DataPropertyName = "Deposit";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDeposit.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDeposit.HeaderText = "Deposit";
            this.colDeposit.Name = "colDeposit";
            this.colDeposit.ReadOnly = true;
            // 
            // colAmountWithdrawal
            // 
            this.colAmountWithdrawal.DataPropertyName = "Withdrawal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAmountWithdrawal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAmountWithdrawal.HeaderText = "Withdrawal";
            this.colAmountWithdrawal.Name = "colAmountWithdrawal";
            this.colAmountWithdrawal.ReadOnly = true;
            // 
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "TransactionType";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colDatePosted
            // 
            this.colDatePosted.DataPropertyName = "DatePosted";
            this.colDatePosted.HeaderText = "DatePosted";
            this.colDatePosted.Name = "colDatePosted";
            this.colDatePosted.ReadOnly = true;
            // 
            // colDateClosed
            // 
            this.colDateClosed.DataPropertyName = "DateClosed";
            this.colDateClosed.HeaderText = "DateClosed";
            this.colDateClosed.Name = "colDateClosed";
            this.colDateClosed.ReadOnly = true;
            // 
            // colCategoryID
            // 
            this.colCategoryID.DataPropertyName = "CategoryID";
            this.colCategoryID.HeaderText = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.ReadOnly = true;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 826);
            this.Controls.Add(this.dgTransactions);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountWithdrawal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatePosted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
    }
}