//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeCompany.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUser
    {
        public int userId { get; set; }
        public string fullName { get; set; }
        public Nullable<bool> isFemale { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string login { get; set; }
        public string passHash { get; set; }
        public Nullable<bool> isSupplierManager { get; set; }
    }
}
