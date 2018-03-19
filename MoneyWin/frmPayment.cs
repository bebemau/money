using MoneyWin.APIHelpers;
using MoneyWin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyWin
{
    public partial class frmPayment : Form
    {
        HttpClient _client = new HttpClient();
        HttpClientHelper _clientHelper = new HttpClientHelper();
        MoneyData.DisplayPayments_Result _formData = new MoneyData.DisplayPayments_Result();

        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(MoneyData.DisplayPayments_Result data)
        {
            InitializeComponent();
            _formData = data;
        }

        private async void frmPayment_Load(object sender, EventArgs e)
        {
            _client = _clientHelper.GetClient();

            this.txtAmount.Text = _formData.TransferAmount.ToString();
            this.txtDescription.Text = _formData.PaymentDescription.ToString();
            this.txtTransferDate.Text = _formData.PaymentDate.ToString();
            await PopulateVendors(_formData.BankID.ToString(), _formData.CCBank.ToString());

            dgSelected.AutoGenerateColumns = false;
            dgSelected.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTransactions.AutoGenerateColumns = false;
            dgTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private async Task PopulateVendors(string fromID = "", string toID = "")
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
            cboFrom.DataSource = banks;
            if(!string.IsNullOrEmpty(fromID))
                cboFrom.SelectedItem = banks.Find(q => q.VendorID == fromID);

            var emptyVendor = new VendorResponseModel() { VendorID = "", VendorName = "-- No Filter --" };
            vendorsAll.Add(emptyVendor);
            vendorsAll.Sort(
                delegate (VendorResponseModel p1, VendorResponseModel p2)
                {
                    return p1.VendorName.CompareTo(p2.VendorName);
                }
            );
            cboTo.DataSource = vendorsAll;
            if(!string.IsNullOrEmpty(toID))
                cboTo.SelectedItem = vendorsAll.Find(q => q.VendorID == toID);
        }

        private async void cboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await PopulateTransactions();
        }

        private async Task PopulateTransactions()
        {
            var request = new GetTransactionRequestModel()
            {
                 VendorID = cboTo.SelectedValue.ToString(),
                  OpenStatus = "0"
            };
            var result = await RESTHelper.PostListOfObjects<GetTransactionRequestModel, TransactionModel>(request, "api/transaction/gettransactions", _client);
            dgTransactions.DataSource = result;
        }
    }
}
