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

namespace MoneyWin
{
    public partial class frmWithdrawal : Form
    {
        TransactionModel formData = new TransactionModel();
        HttpClient _httpClient = new HttpClient();
        HttpClientHelper _clientHelper = new HttpClientHelper();

        public frmWithdrawal(TransactionModel data)
        {
            InitializeComponent();
            formData = data;
        }

        private async void frmWithdrawal_Load(object sender, EventArgs e)
        {
            _httpClient = _clientHelper.GetClient();
            
            if(formData != null)
            {
                this.lblTransactionID.Text = formData.TransactionID;
                this.txtDate.Text = formData.TransactionDate;
                this.txtCheckNumber.Text = formData.CheckNumber;
                await this.PopulateVendors(formData.BankID, formData.VendorID);
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

        private async Task PopulateVendors(string bankID = "", string vendorID = "")
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
            cboVendor.SelectedItem = vendors.Find(q => q.VendorID == vendorID);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
