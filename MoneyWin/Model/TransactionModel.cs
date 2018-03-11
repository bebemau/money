using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyWin.Model
{

    public class TransactionModel
    {
        public string TransactionID { get; set; }
        public string TransactionDate { get; set; }
        public string BankID { get; set; }
        public string VendorID { get; set; }
        public string BankName { get; set; }
        public string VendorName { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public TransactionType TransactionType { get; set; }
        public string ClosedDate { get; set; }
        public string CheckNumber { get; set; }
        public string PaymentID { get; set; }
        public string CategoryID { get; set; }
        public string Category { get; set; }
        public string ScheduledTransfer { get; set; }
        public string DatePosted { get; set; }
        public string PaidCC { get; set; }
        public string Tax { get; set; }
        public string ForeignTransaction { get; set; }
        public string Withdrawal { get; set; }
        public string Deposit { get; set; }
    }

    public class GetTransactionRequestModel
    {
        public string TransactionID { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string BankID { get; set; }
        public string VendorID { get; set; }
        public string AmountFrom { get; set; }
        public string AmountTo { get; set; }
        public string Description { get; set; }
        public string CategoryID { get; set; }
    }
}
