//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyData
{
    using System;
    
    public partial class DisplayPayments_Result
    {
        public int PaymentID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<int> BankID { get; set; }
        public Nullable<int> CCBank { get; set; }
        public string BankName { get; set; }
        public string CCBankName { get; set; }
        public string PaymentDescription { get; set; }
        public Nullable<double> TransferAmount { get; set; }
        public Nullable<int> TransactionID { get; set; }
        public Nullable<int> BillID { get; set; }
        public Nullable<int> Type { get; set; }
        public bool ScheduledTransfer { get; set; }
    }
}
