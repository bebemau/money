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
    
    public partial class DisplayPaymentDetails_Result
    {
        public Nullable<int> PaymentID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<int> BankID { get; set; }
        public string BankName { get; set; }
        public Nullable<int> CCBankID { get; set; }
        public string CCBankName { get; set; }
        public Nullable<double> PaymentAmount { get; set; }
        public string PaymentDescription { get; set; }
        public Nullable<int> VendorID { get; set; }
        public string VendorName { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<short> TransactionType { get; set; }
        public Nullable<double> Amount { get; set; }
        public string TransactionDescription { get; set; }
        public int PaymentDetailID { get; set; }
        public Nullable<int> TransactionID { get; set; }
    }
}
