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
    [RoutePrefix("api/transaction")]
    public class TransactionController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private MoneyData.TransactionData transactionData = new MoneyData.TransactionData();

        public TransactionController()
        {
        }

        [HttpPost]
        [Route("GetTransactions")]
        public List<MoneyData.DisplayTransactions_Result> GetTransactions(GetTransactionRequestModel request)
        {
            return transactionData.GetTransactions(request.TransactionID, request.DateFrom, request.DateTo, request.BankID, request.VendorID, request.AmountFrom, request.AmountTo, request.Description, request.CategoryID, request.OpenStatus);
        }

        [HttpPost]
        [Route("UpdateTransaction")]
        public string UpdateTransaction(string bankID, string vendorID, string transactionDate, string amount, string transactionID="", string categoryID="", string description = "", string checkNumber = "", string datePosted = "", string foreignTransaction = "", string notMyMoney = "", string paidCC = "", string paymentID = "", string tax = "", string transactionType = "")
        {
            int bankIDNew;
            int vendorIDNew;
            DateTime transactionDateNew;
            double amountNew;
            int categoryIDNew;
            DateTime datePostedNew;
            int paymentIDNew;
            short transactionTypeNew;
            double taxNew;
            int checkNumberNew;
            int transactionIDNew = 0;

            if (!string.IsNullOrEmpty(transactionID))
            {
                if(!int.TryParse(transactionID, out transactionIDNew))
                    return "Invalid TransactionID format";
            }
            if (!int.TryParse(bankID, out bankIDNew))
                return "Invalid BankID format";
            if (!int.TryParse(vendorID, out vendorIDNew))
                return "Invalid VendorID format";
            if (!DateTime.TryParse(transactionDate, out transactionDateNew))
                return "Invalid TransactionDate format";
            if (!double.TryParse(amount, out amountNew))
                return "Invalid Amount format";
            if (!int.TryParse(categoryID, out categoryIDNew))
                return "Invalid CategoryID format";
            if (!DateTime.TryParse(datePosted, out datePostedNew))
                return "Invalid DatePosted format";
            if (!int.TryParse(paymentID, out paymentIDNew))
                return "Invalid PaymentID format";
            if (!short.TryParse(transactionType, out transactionTypeNew))
                return "Invalid TransactionType format";
            if (!double.TryParse(tax, out taxNew))
                return "Invalid Tax format";
            if (!int.TryParse(checkNumber, out checkNumberNew))
                return "Invalid CheckNumber format";

            var transaction = new MoneyData.tblTransaction();
            transaction.TransactionID = transactionIDNew;
            transaction.Amount = amountNew;
            transaction.BankID = bankIDNew;
            transaction.CategoryID = categoryIDNew;
            transaction.CheckNumber = checkNumberNew;
            transaction.DatePosted = datePostedNew;
            transaction.Description = description;
            transaction.ForeignTransaction = foreignTransaction == "1" ? true : false;
            transaction.NotMyMoney = notMyMoney == "1" ? true : false;
            transaction.PaidCC = paidCC == "1" ? true : false;
            transaction.PaymentID = paymentIDNew;
            transaction.Tax = taxNew;
            transaction.TransactionDate = transactionDateNew;
            transaction.TransactionType = transactionTypeNew;
            transaction.VendorID = vendorIDNew;

            if (transactionIDNew == 0)
                return transactionData.AddTransaction(transaction).ToString();
            else
                return transactionData.UpdateTransaction(transaction);
        }

        [HttpDelete]
        [Route("DeleteTransaction/{transactionID}")]
        public string DeleteTransaction(string transactionID)
        {
            int transactionIDNew;
            if (int.TryParse(transactionID, out transactionIDNew))
                return transactionData.DeleteTransaction(transactionIDNew);
            else
                return "TransactionID is not in valid format.";
        }
    }
}
