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

namespace MoneyAPI.Controllers
{
    //[Authorize]
    [RoutePrefix("api/vendor")]
    public class VendorController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private MoneyData.VendorData vendorData = new MoneyData.VendorData();

        public VendorController()
        {
        }

        [HttpGet]
        [Route("GetVendors")]
        public List<MoneyData.tblVendor> GetVendors(string vendorID = "")
        {
            return vendorData.GetVendors(vendorID);
        }

        [HttpPost]
        [Route("AddVendor/{vendorName}/{active}/{isBank}")]
        public string AddVendor(string vendorName, string active, string isBank)
        {
            var vendor = new MoneyData.tblVendor();
            vendor.VendorName = vendorName;
            vendor.Active = Convert.ToBoolean(active);
            vendor.IsBank = Convert.ToBoolean(isBank);
            return vendorData.AddVendor(vendor);
        }

        [HttpPut]
        [Route("UpdateVendor/{vendorID}/{vendorName}/{active}/{isBank}")]
        public string UpdateVendor(string vendorID, string vendorName, string active, string isBank)
        {
            int vendorIDNew;
            if (int.TryParse(vendorID, out vendorIDNew))
            {
                var vendor = new MoneyData.tblVendor();
                vendor.VendorID = vendorIDNew;
                vendor.VendorName = vendorName;
                vendor.Active = Convert.ToBoolean(active);
                vendor.IsBank = Convert.ToBoolean(isBank);
                return vendorData.UpdateVendor(vendor);
            }
            else
                return "VendorID is not in valid format.";
        }

        [HttpDelete]
        [Route("DeleteVendor/{vendorID}")]
        public string DeleteVendor(string vendorID)
        {
            int vendorIDNew;
            if (int.TryParse(vendorID, out vendorIDNew))
                return vendorData.DeleteVendor(vendorIDNew);
            else
                return "VendorID is not in valid format.";
        }
    }
}
