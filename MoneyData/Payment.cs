using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace MoneyData
{
    public class PaymentData
    {
        MoneyEntities moneyContext = new MoneyEntities();

        public Tuple<string, List<DisplayPayments_Result>, List<DisplayPaymentDetails_Result>> GetPayments(string withDetails = "", string paymentID = "", string bankID ="", string vendorID="", string paymentAmount="", string paymentDate="")
        {
            int? paymentIDNew = paymentID.ToNullableInt();
            int? bankIDNew = bankID.ToNullableInt();
            int? vendorIDNew = vendorID.ToNullableInt();
            double? paymentAmountNew = paymentAmount.ToNullableDouble();
            DateTime? paymentDateNew = paymentDate.ToNullableDateTime();
            bool withDetailsNew = withDetails == "1" ? true : false;

            if (!string.IsNullOrEmpty(paymentID) && paymentIDNew == null)
                return new Tuple<string, List<DisplayPayments_Result>, List<DisplayPaymentDetails_Result>>("PaymentID is not in valid format", null, null);

            if (!string.IsNullOrEmpty(bankID) && bankIDNew ==null)
                return new Tuple<string, List<DisplayPayments_Result>, List<DisplayPaymentDetails_Result>>("BankID is not in valid format", null, null);

            if (!string.IsNullOrEmpty(vendorID) && vendorIDNew ==null)
                return new Tuple<string, List<DisplayPayments_Result>, List<DisplayPaymentDetails_Result>>("VendorID is not in valid format", null, null);

            if (!string.IsNullOrEmpty(paymentAmount) && paymentAmountNew==null)
                return new Tuple<string, List<DisplayPayments_Result>, List<DisplayPaymentDetails_Result>>("PaymentAmount is not in valid format", null, null);

            if (!string.IsNullOrEmpty(paymentDate) && paymentDateNew==null)
                return new Tuple<string, List<DisplayPayments_Result>, List<DisplayPaymentDetails_Result>>("PaymentDate is not in valid format", null, null);

            var result = moneyContext.DisplayPayments(paymentIDNew, bankIDNew, vendorIDNew, paymentAmountNew, paymentDateNew);

            if (withDetailsNew)
                return new Tuple<string, List<DisplayPayments_Result>, List<DisplayPaymentDetails_Result>>(string.Empty, result.ToList(), null);
            else
            {
                var details = moneyContext.DisplayPaymentDetails(paymentIDNew);
                return new Tuple<string, List<DisplayPayments_Result>, List<DisplayPaymentDetails_Result>>(string.Empty, result.ToList(), details.ToList());
            }
        }

        public string AddUpdatePayment(string bankID, string transferTo, string paymentDate, string paymentAmount, List<MoneyData.tblPaymentDetail> details, string description ="")
        {
            int bankIDNew;
            int transferToNew;
            DateTime paymentDateNew;
            double paymentAmountNew;

            if (!int.TryParse(bankID, out bankIDNew))
                return "BankID must be provided and in valid format.";
            else if (!int.TryParse(transferTo, out transferToNew))
                return "TransferTo must be provided and in valid format.";
            else if (!DateTime.TryParse(paymentDate, out paymentDateNew))
                return "PaymentDate must be provided and in valid format.";
            else if (!double.TryParse(paymentAmount, out paymentAmountNew))
                return "PaymentAmount must be provided and in valid format.";

            var payment = new tblPayment { BankID = bankIDNew, Description = description, PaymentDate = paymentDateNew, TransferAmount = paymentAmountNew, TransferTo = transferToNew };
            moneyContext.tblPayments.Add(payment);
            moneyContext.SaveChanges();
            var paymentID = payment.PaymentID;

            var oldDetails = moneyContext.tblPaymentDetails.Where(a => a.PaymentID == paymentID);
            moneyContext.tblPaymentDetails.RemoveRange(oldDetails);

            var newDetails = details.Select(
                s => new MoneyData.tblPaymentDetail{ PaymentID = paymentID, Description = s.Description, PaymentAmount = s.PaymentAmount, TransactionID = s.TransactionID });

            moneyContext.tblPaymentDetails.AddRange(newDetails);
            moneyContext.SaveChanges();

            return string.Empty;
        }

        //public string UpdatePayment(tblPayment input)
        //{
        //    var result = moneyContext.tblPayments.SingleOrDefault(b => b.PaymentID == input.PaymentID);
        //    if (result != null)
        //    {
        //        result.BankID = input.BankID;
        //        result.Description = input.Description;
        //        result.PaymentDate = input.PaymentDate;
        //        result.ScheduledTransfer = input.ScheduledTransfer;
        //        result.TransferAmount = input.TransferAmount;
        //        result.TransferTo = input.TransferTo;
        //        result.Type = input.Type;
        //        moneyContext.SaveChanges();
        //        return string.Empty;
        //    }
        //    else
        //        return "Payment does not exist.";
        //}

        public string DeletePayment(int paymentID)
        {
            var result = moneyContext.tblPayments.SingleOrDefault(b => b.PaymentID == paymentID);
            if (result != null)
            {
                var details = moneyContext.tblPaymentDetails.Where(a => a.PaymentID == paymentID);
                moneyContext.tblPaymentDetails.RemoveRange(details);
                moneyContext.tblPayments.Remove(result);
                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "Payment does not exist.";
        }
                
    }
}
