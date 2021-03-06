﻿namespace MoneyWin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBank = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtAmountTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTransactionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboVendor = new System.Windows.Forms.ComboBox();
            this.txtDateFrom = new System.Windows.Forms.MaskedTextBox();
            this.txtDateTo = new System.Windows.Forms.MaskedTextBox();
            this.txtAmountFrom = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
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
            this.dgTransactions.Location = new System.Drawing.Point(15, 196);
            this.dgTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.ReadOnly = true;
            this.dgTransactions.RowTemplate.Height = 28;
            this.dgTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransactions.Size = new System.Drawing.Size(2904, 1092);
            this.dgTransactions.TabIndex = 11;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDeposit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDeposit.HeaderText = "Deposit";
            this.colDeposit.Name = "colDeposit";
            this.colDeposit.ReadOnly = true;
            // 
            // colAmountWithdrawal
            // 
            this.colAmountWithdrawal.DataPropertyName = "Withdrawal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAmountWithdrawal.DefaultCellStyle = dataGridViewCellStyle4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "To";
            // 
            // cboBank
            // 
            this.cboBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBank.DisplayMember = "VendorName";
            this.cboBank.FormattingEnabled = true;
            this.cboBank.Location = new System.Drawing.Point(125, 14);
            this.cboBank.Margin = new System.Windows.Forms.Padding(4);
            this.cboBank.Name = "cboBank";
            this.cboBank.Size = new System.Drawing.Size(354, 32);
            this.cboBank.TabIndex = 0;
            this.cboBank.ValueMember = "VendorID";
            this.cboBank.Enter += new System.EventHandler(this.cboBank_Enter);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(2693, 128);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(226, 50);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtAmountTo
            // 
            this.txtAmountTo.Location = new System.Drawing.Point(904, 130);
            this.txtAmountTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountTo.Name = "txtAmountTo";
            this.txtAmountTo.Size = new System.Drawing.Size(138, 29);
            this.txtAmountTo.TabIndex = 7;
            this.txtAmountTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericFields_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount From";
            // 
            // cboTransactionType
            // 
            this.cboTransactionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTransactionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTransactionType.DisplayMember = "VendorName";
            this.cboTransactionType.FormattingEnabled = true;
            this.cboTransactionType.Location = new System.Drawing.Point(689, 16);
            this.cboTransactionType.Margin = new System.Windows.Forms.Padding(4);
            this.cboTransactionType.Name = "cboTransactionType";
            this.cboTransactionType.Size = new System.Drawing.Size(354, 32);
            this.cboTransactionType.TabIndex = 4;
            this.cboTransactionType.ValueMember = "VendorID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Category";
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStatus.DisplayMember = "VendorName";
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "All",
            "Open",
            "Posted",
            "Closed"});
            this.cboStatus.Location = new System.Drawing.Point(1241, 16);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(354, 32);
            this.cboStatus.TabIndex = 8;
            this.cboStatus.ValueMember = "VendorID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1094, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Status";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(1241, 73);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(354, 29);
            this.txtDescription.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1094, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Description";
            // 
            // cboCategory
            // 
            this.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategory.DisplayMember = "Category";
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(689, 70);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(354, 32);
            this.cboCategory.TabIndex = 5;
            this.cboCategory.ValueMember = "CategoryID";
            // 
            // cboVendor
            // 
            this.cboVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVendor.DisplayMember = "VendorName";
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.Location = new System.Drawing.Point(125, 70);
            this.cboVendor.Margin = new System.Windows.Forms.Padding(4);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Size = new System.Drawing.Size(354, 32);
            this.cboVendor.TabIndex = 1;
            this.cboVendor.ValueMember = "VendorID";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(125, 131);
            this.txtDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateFrom.Mask = "00/00/0000";
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(135, 29);
            this.txtDateFrom.TabIndex = 2;
            this.txtDateFrom.ValidatingType = typeof(System.DateTime);
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(344, 131);
            this.txtDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateTo.Mask = "00/00/0000";
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(135, 29);
            this.txtDateTo.TabIndex = 3;
            this.txtDateTo.ValidatingType = typeof(System.DateTime);
            // 
            // txtAmountFrom
            // 
            this.txtAmountFrom.Location = new System.Drawing.Point(689, 128);
            this.txtAmountFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountFrom.Name = "txtAmountFrom";
            this.txtAmountFrom.Size = new System.Drawing.Size(138, 29);
            this.txtAmountFrom.TabIndex = 6;
            this.txtAmountFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericFields_KeyPress);
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(1664, 17);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(166, 140);
            this.btnGO.TabIndex = 10;
            this.btnGO.Text = "Search";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1302);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.cboVendor);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboTransactionType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmountTo);
            this.Controls.Add(this.txtAmountFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboBank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTransactions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBank;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtAmountTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTransactionType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboVendor;
        private System.Windows.Forms.MaskedTextBox txtDateFrom;
        private System.Windows.Forms.MaskedTextBox txtDateTo;
        private System.Windows.Forms.TextBox txtAmountFrom;
        private System.Windows.Forms.Button btnGO;
    }
}