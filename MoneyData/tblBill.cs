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
    
    public partial class tblBill
    {
        public int BillID { get; set; }
        public int VendorID { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> EstPaidDate { get; set; }
        public double Amount { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Description { get; set; }
        public Nullable<int> WithdrawalID { get; set; }
    }
}