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
    
    public partial class tblEbay
    {
        public int ItemID { get; set; }
        public string ItemNumber { get; set; }
        public string Description { get; set; }
        public Nullable<double> StartingPrice { get; set; }
        public Nullable<System.DateTime> DatePosted { get; set; }
        public Nullable<System.DateTime> DateEnded { get; set; }
        public Nullable<double> SellingPrice { get; set; }
        public Nullable<double> Postage { get; set; }
        public Nullable<double> Insurance { get; set; }
        public Nullable<int> Buyer { get; set; }
        public Nullable<System.DateTime> DatePaid { get; set; }
        public Nullable<int> PaymentType { get; set; }
        public Nullable<double> PostagePaid { get; set; }
        public Nullable<double> InsurancePaid { get; set; }
        public Nullable<double> PostFee { get; set; }
        public Nullable<double> FinalValueFee { get; set; }
        public Nullable<System.DateTime> DatePaidPostFee { get; set; }
        public Nullable<System.DateTime> DatePaidFVFee { get; set; }
        public Nullable<System.DateTime> DateMailed { get; set; }
        public string DeliveryConfirmation { get; set; }
        public string Comments { get; set; }
        public Nullable<int> TransactionID { get; set; }
        public Nullable<double> MiscFees { get; set; }
        public Nullable<System.DateTime> DateNPB { get; set; }
        public Nullable<System.DateTime> DateFVFC { get; set; }
        public Nullable<double> RefundAmount { get; set; }
        public Nullable<System.DateTime> DateRefundPaid { get; set; }
        public Nullable<int> RefundTransactionID { get; set; }
    }
}
