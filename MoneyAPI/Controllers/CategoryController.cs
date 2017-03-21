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
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private MoneyData.CategoryData categoryData= new MoneyData.CategoryData();

        public CategoryController()
        {
        }

        [HttpGet]
        [Route("GetCategories")]
        public CategoryResponseModel GetCategories(string categoryID="")
        {
            var categories = categoryData.GetCategories(categoryID);
            var result = new CategoryResponseModel()
            {
                Message = categories.Item1,
                Data = categories.Item2
            };
            return result;
        }

        
    }
}
