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

            dgTransactions.AutoGenerateColumns = false;

            PopulateCategories();

            PopulateVendors();

            PopulateTransactions();

            cboTransactionType.DataSource = Enum.GetValues(typeof(TransactionType));
            cboTransactionType.SelectedItem = TransactionType.All;

            cboStatus.DataSource = Enum.GetValues(typeof(TransactionStatus));
            cboStatus.SelectedItem = TransactionStatus.All;

            this.WindowState = FormWindowState.Maximized;

        }

        private async Task PopulateCategories()
        {
            var data = await RESTHelper.GetSingleObject<CategoryResponseModel>("api/category/GetCategories", _client);
            var categories = data.Data;
            var emptyCategory = new CategoryModel() { Category = "-- No Filter --", CategoryID = "" };
            categories.Add(emptyCategory);
            categories.Sort(
                delegate (CategoryModel p1, CategoryModel p2)
                {
                    return p1.Category.CompareTo(p2.Category);
                }
            );
            cboCategory.DataSource = categories;
        }

        private async Task PopulateVendors()
        {
            var vendorsAll = await RESTHelper.GetListOfObjects<VendorResponseModel>("api/vendor/GetVendors", _client);
            var banks = vendorsAll.Where(a => a.IsBank.ToLower() == "true").ToList();
            var emptyBank = new VendorResponseModel() { VendorID = "", VendorName = "-- No Filter --" };
            banks.Add(emptyBank);
            banks.Sort(
                delegate (VendorResponseModel p1, VendorResponseModel p2)
                {
                    return p1.VendorName.CompareTo(p2.VendorName);
                }
            );
            cboBank.DataSource = banks;

            var vendors = vendorsAll.Where(a => a.IsBank.ToLower() == "false").ToList();
            var emptyVendor = new VendorResponseModel() { VendorID = "", VendorName = "-- No Filter --" };
            vendors.Add(emptyVendor);
            vendors.Sort(
                delegate (VendorResponseModel p1, VendorResponseModel p2)
                {
                    return p1.VendorName.CompareTo(p2.VendorName);
                }
            );
            cboVendor.DataSource = vendors;
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
            DrawTransactionGrid(result);
        }

        private void DrawTransactionGrid(List<TransactionModel> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].TransactionType == ((int)TransactionType.Deposit).ToString())
                    data[i].Deposit = data[i].Amount;
                else
                    data[i].Withdrawal = data[i].Amount;
            }

            dgTransactions.DataSource = data;
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

        private async void btnFilter_Click(object sender, EventArgs e)
        {

            var categoryID = 0;
            var bankID = 0;
            var vendorID = 0;
            var dateFrom = DateTime.MinValue;
            var dateTo = DateTime.MinValue;
            var amountFrom = decimal.MinValue;
            var amountTo = decimal.MinValue;

            var request = new GetTransactionRequestModel();
            if (cboCategory.SelectedValue.ToString() != string.Empty)
                request.CategoryID = cboCategory.SelectedValue.ToString();

            if (cboBank.SelectedValue.ToString() != string.Empty)
                request.BankID = cboBank.SelectedValue.ToString();

            if(cboVendor.SelectedValue.ToString() != string.Empty)
                request.VendorID = cboVendor.SelectedValue.ToString();

            if (txtDateFrom.MaskCompleted)
                request.DateFrom = txtDateFrom.Text;

            if (txtDateTo.MaskCompleted)
                request.DateTo = txtDateTo.Text;

            if (txtAmountFrom.Text != string.Empty)
            {
                if (decimal.TryParse(txtAmountFrom.Text, out amountFrom))
                    request.AmountFrom = txtAmountFrom.Text;
            }

            if (txtAmountTo.Text != string.Empty)
                if (decimal.TryParse(txtAmountTo.Text, out amountTo))
                    request.AmountTo = txtAmountTo.Text;

            var result = await RESTHelper.PostListOfObjects<GetTransactionRequestModel, TransactionModel>(request, "api/transaction/gettransactions", _client);
            DrawTransactionGrid(result);

        }

        private void txtAmountFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == 46) //46=dot
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtAmountTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == 46) //46=dot
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
