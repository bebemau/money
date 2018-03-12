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

namespace MoneyWin
{
    public partial class frmVendors : Form
    {
        HttpClientHelper _clientHelper = new HttpClientHelper();
        HttpClient _client = new HttpClient();
        RESTHelper _apiHelper = new RESTHelper();

        public frmVendors()
        {
            InitializeComponent();
        }

        private async void frmVendors_Load(object sender, EventArgs e)
        {
            _client = _clientHelper.GetClient();

            dgVendors.AutoGenerateColumns = false;

            await PopulateVendors();

        }

        private async Task PopulateVendors(string searchString = "", bool isInsert = false)
        {
            var vendors = await RESTHelper.GetListOfObjects<VendorResponseModel>("api/vendor/GetVendors", _client);
            if(!string.IsNullOrEmpty(searchString))
            {
                vendors = vendors.Where(a => a.VendorName.ToLower().Contains(searchString.ToLower())).ToList();
            }
            else if (isInsert)
            {
                vendors.Add(new VendorResponseModel { VendorID = "0", VendorName = "", IsBank = "false", Active = "true" });
            }

            vendors.Sort(
                delegate (VendorResponseModel p1, VendorResponseModel p2)
                {
                    return p1.VendorName.CompareTo(p2.VendorName);
                }
            );
            dgVendors.DataSource = vendors;

        }

        private async void txtSearchVendor_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                await PopulateVendors(txtSearchVendor.Text);
        }

        private async void btnNewVendor_Click(object sender, EventArgs e)
        {
            //var form = new frmVendor();
            //form.Show();

            await PopulateVendors(string.Empty, true);
        }

        private void dgVendors_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVendors.IsCurrentRowDirty)
            {
                var row = dgVendors.Rows[e.RowIndex];
                var vendorID = row.Cells["colVendorID"].FormattedValue;
                var vendorName = row.Cells["colVendorName"].EditedFormattedValue.ToString();
                var isBank = Convert.ToBoolean(row.Cells["colIsBank"].EditedFormattedValue);
                var isActive = Convert.ToBoolean(row.Cells["colIsActive"].EditedFormattedValue.ToString());

                var vendorModel = new tblVendor();
                vendorModel.VendorID = Convert.ToInt32(vendorID);
                vendorModel.VendorName = vendorName;
                vendorModel.IsBank = isBank;
                vendorModel.Active = isActive;

                SaveVendor(vendorModel);
            }
            
        }

        private async void SaveVendor(tblVendor vendorModel)
        {
            var vendorObject = new VendorData();

            if (vendorModel.VendorID != 0)
                vendorObject.UpdateVendor(vendorModel);
            else
                vendorObject.AddVendor(vendorModel);

            await PopulateVendors();
        }

    }
}
