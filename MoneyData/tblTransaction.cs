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
    using System.Collections.Generic;
    
    public partial class tblTransaction
    {
        public int TransactionID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<short> TransactionType { get; set; }
        public Nullable<int> BankID { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> CheckNumber { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Description { get; set; }
        public bool PaidCC { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public Nullable<System.DateTime> DatePosted { get; set; }
        public bool NotMyMoney { get; set; }
        public Nullable<double> Tax { get; set; }
        public bool ForeignTransaction { get; set; }
    }
}
