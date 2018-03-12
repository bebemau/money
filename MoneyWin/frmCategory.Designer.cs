namespace MoneyWin
{
    partial class frmCategory
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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.dgCategories = new System.Windows.Forms.DataGridView();
            this.colCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(254, 51);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(449, 29);
            this.txtCategory.TabIndex = 1;
            this.txtCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchCategory_OnKeyDown);
            // 
            // dgCategories
            // 
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategoryID,
            this.colCategory});
            this.dgCategories.Location = new System.Drawing.Point(66, 112);
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.RowTemplate.Height = 31;
            this.dgCategories.Size = new System.Drawing.Size(942, 880);
            this.dgCategories.TabIndex = 2;
            this.dgCategories.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategories_RowLeave);
            // 
            // colCategoryID
            // 
            this.colCategoryID.DataPropertyName = "CategoryID";
            this.colCategoryID.HeaderText = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            // 
            // colCategory
            // 
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "CategoryName";
            this.colCategory.Name = "colCategory";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(772, 33);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(236, 47);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New Category";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 1017);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgCategories);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DataGridView dgCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.Button btnNew;
    }
}