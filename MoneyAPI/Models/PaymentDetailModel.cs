using System;
using System.Collections.Generic;

namespace MoneyAPI.Models
{
    public class PaymentDetailModel
    {
        public string PaymentDetailID { get; set; }

        public string PaymentID { get; set; }

        public string TransactionID { get; set; }

        public string PaymentAmount { get; set; }

        public string Description { get; set; }
    }
}
