using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyData
{
    public class TransactionData
    {
        MoneyEntities moneyContext = new MoneyEntities();

        public List<DisplayTransactions_Result> GetTransactions(string dateFrom = "", string dateTo = "", string bankID ="", string vendorID = "", string amountFrom="", string amountTo="", string description="", string categoryID="" )
        {
            DateTime? dateFromNew = !string.IsNullOrEmpty(dateFrom) ? Convert.ToDateTime(dateFrom) : (DateTime?)null;
            DateTime? dateToNew = !string.IsNullOrEmpty(dateTo) ? Convert.ToDateTime(dateTo) : (DateTime?)null;
            int? bankIDNew = !string.IsNullOrEmpty(bankID) ? Convert.ToInt32(bankID) : (int?)null;
            int? vendorIDNew = !string.IsNullOrEmpty(vendorID) ? Convert.ToInt32(vendorID) : (int?)null;
            int? categoryIDNew = !string.IsNullOrEmpty(categoryID) ? Convert.ToInt32(categoryID) : (int?)null;
            double? amountFromNew = !string.IsNullOrEmpty(amountFrom) ? Convert.ToDouble(amountFrom) : (double?)null;
            double? amountToNew = !string.IsNullOrEmpty(amountTo) ? Convert.ToDouble(amountTo) : (double?)null;

            var result = moneyContext.DisplayTransactions(dateFromNew, dateToNew, bankIDNew, vendorIDNew, amountFromNew, amountToNew, description, categoryIDNew).ToList();
            return result;
        }

        public string AddTransaction(tblTransaction transaction)
        {
            moneyContext.tblTransactions.Add(transaction);
            moneyContext.SaveChanges();
            return string.Empty;
        }

        public string UpdateTransaction(tblTransaction input)
        {
            var result = moneyContext.tblTransactions.SingleOrDefault(b => b.TransactionID == input.TransactionID);
            if (result != null)
            {
                result.Amount = input.Amount;
                result.BankID = input.BankID;
                result.CategoryID = input.CategoryID;
                result.CheckNumber = input.CheckNumber;
                result.DatePosted = input.DatePosted;
                result.Description = input.Description;
                result.ForeignTransaction = input.ForeignTransaction;
                result.NotMyMoney = input.NotMyMoney;
                result.PaidCC = input.PaidCC;
                result.PaymentID = input.PaymentID;
                result.Tax = input.Tax;
                result.TransactionDate = input.TransactionDate;
                result.TransactionType = input.TransactionType;
                result.VendorID = input.VendorID;

                moneyContext.SaveChanges();
                return string.Empty;
            }
            else
                return "Transaction does not exist.";
        }

        public string DeleteTransaction(int transactionID)
        {
            var result = moneyContext.tblTransactions.SingleOrDefault(b => b.TransactionID == transactionID);
            if (result != null)
            {
                var payment = moneyContext.tblPaymentDetails.SingleOrDefault(b => b.TransactionID == transactionID);

                if (payment == null)
                {
                    moneyContext.tblTransactions.Remove(result);
                    moneyContext.SaveChanges();
                    return string.Empty;
                }
                else
                    return "Transaction cannot be deleted due to related transactions.";
            }
            else
                return "Transaction does not exist.";
        }
    }
}
