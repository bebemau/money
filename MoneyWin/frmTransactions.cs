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
        HttpClientHelper _clientHelper = new HttpClientHelper();
        HttpClient _client = new HttpClient();
        RESTHelper _apiHelper = new RESTHelper();

        public frmTransactions()
        {
            InitializeComponent();
        }

        private  void frmTransactions_Load(object sender, EventArgs e)
        {
            _client = _clientHelper.GetClient();

            PopulateCategories();

            PopulateVendors();

            PopulateTransactions();

            this.WindowState = FormWindowState.Maximized;

        }

        private async Task PopulateCategories()
        {
            var data = await RESTHelper.GetSingleObject<CategoryResponseModel>("api/category/GetCategories", _client);
            var categories = data.Data;
            var emptyCategory = new CategoryModel() { Category = "-- No Filter --", CategoryID = "" };
            categories.Add(emptyCategory);
            var sorted = categories.OrderBy(a => a.Category).ToList();
            cboCategory.DataSource = sorted;
        }

        private async Task PopulateVendors()
        {
            var vendorsAll = await RESTHelper.GetListOfObjects<VendorResponseModel>("api/vendor/GetVendors", _client);
            var banks = vendorsAll.Where(a => a.IsBank.ToLower() == "true").ToList();
            var emptyBank = new VendorResponseModel() { VendorID = "", VendorName = "-- No Filter --" };
            banks.Add(emptyBank);
            var sortedBanks = banks.OrderBy(a => a.VendorName).ToList();
            cboBank.DataSource = sortedBanks;

            var vendors = vendorsAll.Where(a => a.IsBank.ToLower() == "false").ToList();
            var emptyVendor = new VendorResponseModel() { VendorID = "", VendorName = "-- No Filter --" };
            vendors.Add(emptyVendor);
            var sortedVendors = vendors.OrderBy(a => a.VendorName).ToList();
            cboVendor.DataSource = sortedVendors;
        }

        private async Task PopulateTransactions()
        {
            var defaultDatagridDays = ConfigurationManager.AppSettings["DefaultDatagridDays"];
            var dateFrom = DateTime.Now.AddDays(-Convert.ToInt16(defaultDatagridDays));
            var request = new GetTransactionRequestModel()
            {
                DateFrom = dateFrom.ToString()
            };
            var result = await RESTHelper.PostListOfObjects<GetTransactionRequestModel, TransactionModel>(request, "api/transaction/gettransactions", _client);
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].TransactionType == ((int)TransactionType.Deposit).ToString())
                    result[i].Deposit = result[i].Amount;
                else
                    result[i].Withdrawal = result[i].Amount;
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var categoryID = cboCategory.SelectedValue;
        }
    }
}
