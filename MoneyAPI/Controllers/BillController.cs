using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using MoneyAPI.Models;
using MoneyAPI.Providers;
using MoneyAPI.Results;
using MoneyAPI.Filters;

namespace MoneyAPI.Controllers
{
    //[Authorize]
    //[DeflateCompression]
    [RoutePrefix("api/bill")]
    public class BillController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private MoneyData.BillData dataTier = new MoneyData.BillData();

        public BillController()
        {
        }

        [HttpGet]
        [Route("Bills")]
        public List<MoneyData.DisplayBills_Result> GetBills(string vendorID = "")
        {
            return dataTier.GetBills(vendorID);
        }

        [HttpPost]
        [Route("AddBill/{vendorID}/{dueDate}/{categoryID}/{description}/{amount}")]
        public string AddBill(string vendorID, string categoryID, string amount, string description ="")
        {
            int vendorIDNew;
            int categoryIDNew;
            double amountNew;

            if (!int.TryParse(vendorID, out vendorIDNew))
                return "Invalid VendorID";
            else if (!int.TryParse(categoryID, out categoryIDNew))
                return "Invalid CategoryID";
            else if (!double.TryParse(amount, out amountNew))
                return "Invalid Amount";

            var data = new MoneyData.tblBill();
            data.VendorID = vendorIDNew;
            data.CategoryID = categoryIDNew;
            data.Amount = amountNew;
            data.Description = description;
            return dataTier.AddBill(data);
        }

        [HttpPut]
        [Route("UpdateBill/{billID}/{vendorID}/{categoryID}/{amount}/{description}")]
        public string UpdateBill(string billID, string vendorID, string amount, string categoryID, string description= "")
        {
            int billIDNew;
            int vendorIDNew;
            double amountNew;
            int categoryIDNew;

            if (!int.TryParse(billID, out billIDNew))
                return "Invalid BillID";
            if (!int.TryParse(vendorID, out vendorIDNew))
                return "Invalid VendorID";
            if (!double.TryParse(amount, out amountNew))
                return "Invalid Amount";
            if (!int.TryParse(categoryID, out categoryIDNew))
                return "Invalid CategoryID";

            var data = new MoneyData.tblBill();
            data.BillID = billIDNew;
            data.VendorID = vendorIDNew;
            data.Amount = amountNew;
            data.CategoryID = categoryIDNew;
            data.Description = description;
            return dataTier.UpdateBill(data);
        }

        [HttpDelete]
        [Route("DeleteBill/{billID}")]
        public string DeleteBill(string billID)
        {
            int billIDNew;
            if (int.TryParse(billID, out billIDNew))
                return dataTier.DeleteBill(billIDNew);
            else
                return "BillID is not in valid format.";
        }
    }
}
