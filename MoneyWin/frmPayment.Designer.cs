namespace MoneyWin
{
    partial class frmPayment
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgSelected = new System.Windows.Forms.DataGridView();
            this.txtTransferDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRunningTotal = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.ckTransferOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(2098, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 47);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(165, 20);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(415, 32);
            this.cboFrom.TabIndex = 0;
            // 
            // cboTo
            // 
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(683, 17);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(430, 32);
            this.cboTo.TabIndex = 1;
            this.cboTo.SelectedIndexChanged += new System.EventHandler(this.cboTo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1447, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(165, 86);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1064, 29);
            this.txtDescription.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // dgSelected
            // 
            this.dgSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelected.Location = new System.Drawing.Point(39, 166);
            this.dgSelected.Name = "dgSelected";
            this.dgSelected.RowTemplate.Height = 31;
            this.dgSelected.Size = new System.Drawing.Size(2182, 543);
            this.dgSelected.TabIndex = 10;
            // 
            // txtTransferDate
            // 
            this.txtTransferDate.Location = new System.Drawing.Point(1213, 17);
            this.txtTransferDate.Name = "txtTransferDate";
            this.txtTransferDate.Size = new System.Drawing.Size(188, 29);
            this.txtTransferDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1138, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // dgTransactions
            // 
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Location = new System.Drawing.Point(39, 734);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.RowTemplate.Height = 31;
            this.dgTransactions.Size = new System.Drawing.Size(2182, 543);
            this.dgTransactions.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1738, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Running Total";
            // 
            // txtRunningTotal
            // 
            this.txtRunningTotal.Enabled = false;
            this.txtRunningTotal.Location = new System.Drawing.Point(1879, 110);
            this.txtRunningTotal.Name = "txtRunningTotal";
            this.txtRunningTotal.Size = new System.Drawing.Size(175, 29);
            this.txtRunningTotal.TabIndex = 15;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1543, 14);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(175, 29);
            this.txtAmount.TabIndex = 3;
            // 
            // ckTransferOnly
            // 
            this.ckTransferOnly.AutoSize = true;
            this.ckTransferOnly.Location = new System.Drawing.Point(1313, 86);
            this.ckTransferOnly.Name = "ckTransferOnly";
            this.ckTransferOnly.Size = new System.Drawing.Size(364, 29);
            this.ckTransferOnly.TabIndex = 5;
            this.ckTransferOnly.Text = "Transfer Only (No impact on balance)";
            this.ckTransferOnly.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2264, 1295);
            this.Controls.Add(this.ckTransferOnly);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRunningTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgTransactions);
            this.Controls.Add(this.txtTransferDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgSelected);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgSelected;
        private System.Windows.Forms.MaskedTextBox txtTransferDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgTransactions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRunningTotal;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.CheckBox ckTransferOnly;
    }
}