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

        private async Task PopulateVendors(string searchString = "")
        {
            var vendors = await RESTHelper.GetListOfObjects<VendorResponseModel>("api/vendor/GetVendors", _client);
            if(!string.IsNullOrEmpty(searchString))
            {
                vendors = vendors.Where(a => a.VendorName.ToLower().Contains(searchString.ToLower())).ToList();
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
    }
}
