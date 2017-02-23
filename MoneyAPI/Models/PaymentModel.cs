using System;
using System.Collections.Generic;

namespace MoneyAPI.Models
{
    public class PaymentResponseModel
    {
        public string Message { get; set; }

        public List<MoneyData.DisplayPayments_Result> PaymentData { get; set; }

        public List<MoneyData.DisplayPaymentDetails_Result> PaymentDetailsData { get; set; }

    }

    public class AddPaymentRequestModel
    {
        public string BankID { get; set; }
        public string TransferToID { get; set; }

        public string PaymentDate { get; set; }

        public string CategoryID { get; set; }

        public string PaymentAmount { get; set; }

        public string Description { get; set; }

        public List<PaymentDetailModel> PaymentDetails { get; set; }
    }
}
