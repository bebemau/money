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
    public partial class frmTransfers : Form
    {
        HttpClient _client = new HttpClient();
        HttpClientHelper _clientHelper = new HttpClientHelper();

        public frmTransfers()
        {
            InitializeComponent();
        }

        private async void frmTransfers_Load(object sender, EventArgs e)
        {
            _client = _clientHelper.GetClient();

            dgResults.AutoGenerateColumns = false;
            dgResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            await PopulateVendors();
            this.WindowState = FormWindowState.Maximized;

            cboVendorFrom.Focus();
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
            var copy = new List<VendorResponseModel>(banks);

            cboVendorFrom.DataSource = banks;
            cboVendorTo.DataSource = copy;
        }

        private async Task PopulateTransactions()
        {
            var request = new GetPaymentsRequestModel()
            {
                DateFrom = txtDateFrom.MaskFull ? txtDateFrom.Text : null,
                DateTo = txtDateTo.MaskFull ? txtDateTo.Text : null,
                VendorFromID = cboVendorFrom.SelectedValue.ToString(),
                VendorToID = cboVendorTo.SelectedValue.ToString()
            };

            var result = await RESTHelper.PostListOfObjectsGetSingle<GetPaymentsRequestModel, PaymentResponseModel>(request, "api/payment/payments", _client);
            dgResults.DataSource = result.PaymentData;
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            await PopulateTransactions();
        }

        private void txtDateFrom_Enter(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).SelectAll();
        }

        private void txtDateTo_Enter(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).SelectAll();
        }

        private void dgTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgResults.CurrentRow;

            var data = new MoneyData.DisplayPayments_Result();
            data.TransactionID = Convert.ToInt32(row.Cells[colTransactionID.Index].Value);
            data.BankID = Convert.ToInt32(row.Cells[colBankID.Index].Value);
            data.BillID = Convert.ToInt32(row.Cells[colBillID.Index].Value);
            data.CCBank = Convert.ToInt32(row.Cells[colCCBank.Index].Value);
            data.PaymentDate= Convert.ToDateTime(row.Cells[colPaymentDate.Index].Value);
            data.PaymentDescription= row.Cells[colPaymentDescription.Index].Value.ToString();
            data.PaymentID= Convert.ToInt32(row.Cells[colPaymentID.Index].Value);
            data.TransferAmount= Convert.ToDouble(row.Cells[colTransferAmount.Index].Value);
            data.Type= Convert.ToInt32(row.Cells[colType.Index].Value);
            
            var form = new frmPayment(data);
            form.Show();
        }
    }
}
