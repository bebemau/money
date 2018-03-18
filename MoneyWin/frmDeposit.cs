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
using MoneyWin.APIHelpers;
using System.Net.Http;
using MoneyData;
using Common;

namespace MoneyWin
{
    public partial class frmDeposit : Form
    {
        TransactionModel formData = new TransactionModel();
        HttpClient _httpClient = new HttpClient();
        HttpClientHelper _clientHelper = new HttpClientHelper();

        public frmDeposit(TransactionModel data)
        {
            InitializeComponent();
            formData = data;
        }

        public frmDeposit()
        {
            InitializeComponent();
        }

        private async void frmDeposit_Load(object sender, EventArgs e)
        {
            _httpClient = _clientHelper.GetClient();

            if (formData != null)
            {
                this.lblTransactionID.Text = formData.TransactionID;
                this.txtDate.Text = formData.TransactionDate;
                await this.PopulateBanks(formData.BankID, formData.VendorID);
                await this.PopulateCategories(formData.CategoryID);
                this.txtAmount.Text = formData.Amount;
            }

        }

        private async Task PopulateCategories(string categoryID = "")
        {
            var data = await RESTHelper.GetSingleObject<CategoryResponseModel>("api/category/GetCategories", _httpClient);
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
            cboCategory.SelectedItem = categories.Find(q => q.CategoryID == categoryID);
        }

        private async Task PopulateBanks(string bankID = "", string vendorID = "")
        {
            var vendorsAll = await RESTHelper.GetListOfObjects<VendorResponseModel>("api/vendor/GetVendors", _httpClient);
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
            cboBank.SelectedItem = banks.Find(q => q.VendorID == bankID);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var transaction = new tblTransaction();
            transaction.Amount = Convert.ToDouble(this.txtAmount.Text);
            transaction.BankID = cboBank.SelectedValue.ToString().ToNullableInt();
            transaction.CategoryID = cboCategory.SelectedValue.ToString().ToNullableInt();
            transaction.DatePosted = txtDatePosted.Text.ToNullableDateTime();
            transaction.Description = txtDescription.Text;
            transaction.TransactionDate = txtDate.Text.ToNullableDateTime();
            transaction.TransactionType = (int)TransactionType.Withdrawal;
            transaction.TransactionID = string.IsNullOrEmpty(lblTransactionID.Text) ? 0 : Convert.ToInt32(lblTransactionID.Text);

            var data = new TransactionData();
            if (transaction.TransactionID == 0)
            {
                var id = data.AddTransaction(transaction);
                this.lblTransactionID.Text = id.ToString();
            }
            else
                data.UpdateTransaction(transaction);
        }

        private void NumericFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == 46) //46=dot
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtDate_Validating(object sender, CancelEventArgs e)
        {
            if (!txtDate.MaskCompleted)
                e.Cancel = true;
        }

        private void txtDatePosted_Validating(object sender, CancelEventArgs e)
        {
            if (!txtDatePosted.MaskCompleted && !string.IsNullOrEmpty(txtDatePosted.Text))
                e.Cancel = true;
        }
    }
}
