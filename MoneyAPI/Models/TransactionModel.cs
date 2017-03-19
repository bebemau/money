using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAPI.Models
{
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
