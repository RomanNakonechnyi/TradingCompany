//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeCompanyDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrder
    {
        public int orderID { get; set; }
        public int provProdID { get; set; }
        public int count { get; set; }
        public string address { get; set; }
        public decimal price { get; set; }
    
        public virtual tblProviderProduct tblProviderProduct { get; set; }
    }
}
