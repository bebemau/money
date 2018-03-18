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
    [RoutePrefix("api/payment")]
    public class PaymentController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private MoneyData.PaymentData dataTier = new MoneyData.PaymentData();

        public PaymentController()
        {
        }

        [HttpPost]
        [Route("Payments")]
        public PaymentResponseModel GetPayments(GetPaymentsRequestModel request)
        {
            var input = dataTier.GetPayments(request.WithDetails, request.PaymentID, request.VendorFromID, request.VendorToID, request.PaymentAmount, request.DateFrom, request.DateTo  );
            var result = new PaymentResponseModel();
            result.Message = input.Item1;
            result.PaymentData = input.Item2;
            result.PaymentDetailsData = input.Item3;
            return result;
        }

        [HttpPost]
        [Route("AddPayment")]
        public string AddUpdatePayment(AddPaymentRequestModel input)
        {
            var paymentDetails = new List<MoneyData.tblPaymentDetail>();
            var detailErrorMessage = string.Empty;

            foreach (var a in input.PaymentDetails)
            {
                var detail = new MoneyData.tblPaymentDetail();
                double paymentAmount;
                int paymentDetailID;
                int paymentID;
                int transactionID;

                if (!double.TryParse(a.PaymentAmount, out paymentAmount))
                {
                    detailErrorMessage = "While processing payment details, PaymentAmount must be provided and in valid format: " + a.PaymentAmount;
                    break;
                }
                else
                    detail.PaymentAmount = paymentAmount;

                if (!int.TryParse(a.PaymentID, out paymentID) && !string.IsNullOrEmpty(a.PaymentID))
                {
                    detailErrorMessage = "While processing payment details, PaymentID is not in valid format: " + a.PaymentID;
                    break;
                }
                else if (!string.IsNullOrEmpty(a.PaymentID))
                {
                    detail.PaymentID = Convert.ToInt16(a.PaymentID);
                }

                if (!int.TryParse(a.PaymentDetailID, out paymentDetailID) && !string.IsNullOrEmpty(a.PaymentDetailID))
                {
                    detailErrorMessage = "While processing payment details, PaymentDetailID is not in valid format: " + a.PaymentDetailID;
                    break;
                }
                else if(!string.IsNullOrEmpty(a.PaymentDetailID))
                    detail.PaymentDetailID = Convert.ToInt16(a.PaymentDetailID);

                if (!int.TryParse(a.TransactionID, out transactionID))
                {
                    detailErrorMessage = "While processing payment details, TransactionID must be provided and in valid format: " + a.TransactionID;
                    break;
                }
                else
                    detail.TransactionID = Convert.ToInt16(a.TransactionID);

                detail.Description = a.Description;
                paymentDetails.Add(detail);
            }
            if (detailErrorMessage != string.Empty)
                return detailErrorMessage;

            return dataTier.AddUpdatePayment(input.PaymentID, input.BankID, input.TransferToID, input.PaymentDate, input.PaymentAmount, paymentDetails, input.Description);

        }

        [HttpDelete]
        [Route("DeletePayment/{paymentID}")]
        public string DeletePayment(string paymentID)
        {
            int paymentIDNew;
            if (int.TryParse(paymentID, out paymentIDNew))
                return dataTier.DeletePayment(paymentIDNew);
            else
                return "PaymentID is not in valid format.";
        }
    }
}
