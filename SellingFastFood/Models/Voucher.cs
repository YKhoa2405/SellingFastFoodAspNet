//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SellingFastFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voucher
    {
        public int id { get; set; }
        public string Code { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
    }
}
