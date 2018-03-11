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

namespace MoneyWin
{
    public partial class frmMain : Form
    {
        HttpClientHelper clientHelper = new HttpClientHelper();
        HttpClient client = new HttpClient();
        RESTHelper apiHelper = new RESTHelper();

        public frmMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            client = clientHelper.GetClient();
            var result = await RESTHelper.GetSingleObject<string>("api/balance/getbalance", client);
            lblBalance.Text = result.ToString();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            var form = new frmTransactions();
            form.Show();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            var form = new frmVendors();
            form.Show();
        }
    }
}
