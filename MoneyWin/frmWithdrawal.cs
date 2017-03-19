using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyWin.Model;

namespace MoneyWin
{
    public partial class frmWithdrawal : Form
    {
        TransactionModel formData = new TransactionModel();

        public frmWithdrawal(TransactionModel data)
        {
            InitializeComponent();
            formData = data;
        }

        private void frmWithdrawal_Load(object sender, EventArgs e)
        {
            this.lblTransactionID.Text = formData.TransactionID;
            this.txtDate.Text = formData.TransactionDate;
            this.txtCheckNumber.Text = formData.CheckNumber;

        }
    }
}
