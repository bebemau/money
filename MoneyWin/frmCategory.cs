using MoneyData;
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
    public partial class frmCategory : Form
    {
        HttpClientHelper _clientHelper = new HttpClientHelper();
        HttpClient _client = new HttpClient();
        RESTHelper _apiHelper = new RESTHelper();

        public frmCategory()
        {
            InitializeComponent();
        }

        private async void frmCategory_Load(object sender, EventArgs e)
        {
            _client = _clientHelper.GetClient();

            dgCategories.AutoGenerateColumns = false;

            await PopulateCategories();
        }

        private async Task PopulateCategories(string searchString = "", bool isInsert = false)
        {
            var data = await RESTHelper.GetSingleObject<CategoryResponseModel>("api/category/GetCategories", _client);
            var categories = data.Data;
            if (!string.IsNullOrEmpty(searchString))
            {
                categories = categories.Where(a => a.Category.ToLower().Contains(searchString.ToLower())).ToList();
            }
            else if (isInsert)
            {
                categories.Add(new CategoryModel { CategoryID = "0", Category = "" });
            }
            categories.Sort(
                delegate (CategoryModel p1, CategoryModel p2)
                {
                    return p1.Category.CompareTo(p2.Category);
                }
            );
            dgCategories.DataSource = categories;
        }

        private async void txtSearchCategory_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                await PopulateCategories(txtCategory.Text);
        }

        private async void btnNew_Click(object sender, EventArgs e)
        {
            await PopulateCategories(string.Empty, true);
        }

        private void dgCategories_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategories.IsCurrentRowDirty)
            {
                var row = dgCategories.Rows[e.RowIndex];
                var categoryID = row.Cells["colCategoryID"].FormattedValue;
                var categoryName = row.Cells["colCategory"].EditedFormattedValue.ToString();

                var model = new tblCategory();
                model.CategoryID = Convert.ToInt32(categoryID);
                model.Category = categoryName;

                SaveCategory(model);
            }
        }

        private async void SaveCategory(tblCategory model)
        {
            var categoryObject = new CategoryData();

            if (model.CategoryID != 0)
                categoryObject.UpdateCategory(model);
            else
                categoryObject.AddCategory(model);

            await PopulateCategories();
        }
    }
}
