using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace MoneyData
{
    public class PaymentDetailData
    {
        MoneyEntities moneyContext = new MoneyEntities();

        public Tuple<string, List<DisplayPaymentDetails_Result>> GetPaymentDetails(string paymentID = "")
        {
            int? paymentIDNew = paymentID.ToNullableInt();

            if (!string.IsNullOrEmpty(paymentID) && paymentIDNew == null)
                return new Tuple<string, List<DisplayPaymentDetails_Result>>("PaymentID is not in valid format", null);

            var result = moneyContext.DisplayPaymentDetails(paymentIDNew);
            return new Tuple<string, List<DisplayPaymentDetails_Result>>(string.Empty, result.ToList());
        }

        public string AddPaymentDetail(tblPaymentDetail input)
        {
            moneyContext.tblPaymentDetails.Add(input);
            moneyContext.SaveChanges();
            return string.Empty;
        }

        public string UpdatePaymentDetail(tblPaymentDetail input)
        {
            var result = moneyContext.tblPaymentDetails.SingleOrDefault(b => b.PaymentDetailID == input.PaymentDetailID);
            if (result != null)
            {
                result.PaymentAmount = input.PaymentAmount;
                result.PaymentID = input.PaymentID;
                result.Description = input.Description;
                result.TransactionID = input.TransactionID;
                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "Payment does not exist.";
        }

        public string DeletePaymentDetail(int paymentDetailID)
        {
            var result = moneyContext.tblPaymentDetails.SingleOrDefault(b => b.PaymentDetailID == paymentDetailID);
            if (result != null)
            {
                moneyContext.tblPaymentDetails.Remove(result);
                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "PaymentDetail does not exist.";
        }
                
    }
}
