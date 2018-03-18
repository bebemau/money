using System;
using System.Collections.Generic;

namespace MoneyWin.Model
{
    public class PaymentResponseModel
    {
        public string Message { get; set; }

        public List<MoneyData.DisplayPayments_Result> PaymentData { get; set; }

        public List<MoneyData.DisplayPaymentDetails_Result> PaymentDetailsData { get; set; }

    }

    public class GetPaymentsRequestModel
    {
        public string WithDetails { get; set; }
        public string PaymentID { get; set; }
        public string VendorFromID { get; set; }
        public string VendorToID { get; set; }
        public string PaymentAmount { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }

    public class PaymentDetailModel
    {
        public string PaymentDetailID { get; set; }

        public string PaymentID { get; set; }

        public string TransactionID { get; set; }

        public string PaymentAmount { get; set; }

        public string Description { get; set; }
    }

    public class AddPaymentRequestModel
    {
        public string PaymentID { get; set; }
        public string BankID { get; set; }
        public string TransferToID { get; set; }

        public string PaymentDate { get; set; }

        public string CategoryID { get; set; }

        public string PaymentAmount { get; set; }

        public string Description { get; set; }

        public List<PaymentDetailModel> PaymentDetails { get; set; }
    }
}
