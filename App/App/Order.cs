//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public Nullable<int> Week { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> ItemId { get; set; }
    
        public virtual Item Item { get; set; }
    }
}