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
    
    public partial class tblPayment
    {
        public int PaymentID { get; set; }
        public Nullable<int> BankID { get; set; }
        public Nullable<int> TransferTo { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<double> TransferAmount { get; set; }
        public string Description { get; set; }
        public Nullable<int> Type { get; set; }
        public bool ScheduledTransfer { get; set; }
    }
}
