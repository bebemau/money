using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyWin.APIHelpers;
using System.Net.Http;
using MoneyWin.Model;
using System.Configuration;

namespace MoneyWin
{
    public partial class frmTransactions : Form
    {
        HttpClientHelper clientHelper = new HttpClientHelper();
        HttpClient client = new HttpClient();
        RESTHelper apiHelper = new RESTHelper();

        public frmTransactions()
        {
            InitializeComponent();
        }

        private async void frmTransactions_Load(object sender, EventArgs e)
        {
            client = clientHelper.GetClient();
            var defaultDatagridDays = ConfigurationManager.AppSettings["DefaultDatagridDays"];
            var dateFrom = DateTime.Now.AddDays(-Convert.ToInt16(defaultDatagridDays));
            var request = new GetTransactionRequestModel()
            {
                DateFrom = dateFrom.ToString()
            };

            Console.WriteLine(dateFrom.ToString());
            var result = await RESTHelper.PostListOfObjects<GetTransactionRequestModel, TransactionModel>(request, "api/transaction/gettransactions", client);
            for(int i=0;i<result.Count;i++)
            {
                if (result[i].TransactionType == ((int)TransactionType.Deposit).ToString())
                    result[i].Deposit = result[i].Amount;
                else
                    result[i].Withdrawal = result[i].Amount;

                Console.WriteLine(result[i].TransactionType);
            }

            dgTransactions.AutoGenerateColumns = false;
            dgTransactions.DataSource = result;
        }

        private void dgTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgTransactions.CurrentRow;
            var data = new TransactionModel();
            data.TransactionID = row.Cells[colTransactionID.Index].Value.ToString();
            data.TransactionType = row.Cells[colTransactionType.Index].Value.ToString();
            data.Amount = row.Cells[colTransactionType.Index].Value.ToString() == "1" ? row.Cells[colDeposit.Index].Value.ToString() : row.Cells[colAmountWithdrawal.Index].Value.ToString();
            data.BankID = row.Cells[colBankID.Index].Value.ToString();
            data.CheckNumber = row.Cells[colCheckNumber.Index].Value == null ? string.Empty : row.Cells[colCheckNumber.Index].Value.ToString();
            data.CategoryID = row.Cells[colCategoryID.Index].Value == null ? string.Empty : row.Cells[colCategoryID.Index].Value.ToString();
            data.DatePosted = row.Cells[colDatePosted.Index].Value == null ? string.Empty : row.Cells[colDatePosted.Index].Value.ToString();
            data.Description = row.Cells[colDescription.Index].Value == null ? string.Empty : row.Cells[colDescription.Index].Value.ToString();
            data.TransactionDate = row.Cells[colDate.Index].Value.ToString();
            data.VendorID = row.Cells[colVendorID.Index].Value == null ? string.Empty : row.Cells[colVendorID.Index].Value.ToString();

            if (row.Cells[colTransactionType.Index].Value.ToString() == ((int)TransactionType.Withdrawal).ToString())
            {
                var form = new frmWithdrawal(data); 
                form.Show();
            }
        }
    }
}
