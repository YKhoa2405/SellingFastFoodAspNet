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
    
    public partial class Evaluate
    {
        public int EvaluateID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string EvaluateContent { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<System.DateTime> EvaluateDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
