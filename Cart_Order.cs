//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestPro.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart_Order
    {
        public int Id { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Users Users { get; set; }
    }
}
