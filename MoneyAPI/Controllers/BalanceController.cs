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
    [RoutePrefix("api/balance")]
    public class BalanceController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private MoneyData.BalanceData dataTier = new MoneyData.BalanceData();

        public BalanceController()
        {
        }

        [HttpGet]
        [Route("GetBalance")]
        public double GetBalance()
        {
            return dataTier.GetBalance();
        }
    }
}
