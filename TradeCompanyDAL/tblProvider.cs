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
    
    public partial class tblProvider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProvider()
        {
            this.tblProviderProducts1 = new HashSet<tblProviderProduct>();
        }
    
        public int providerID { get; set; }
        public string name { get; set; }
        public Nullable<int> rating { get; set; }
        public Nullable<bool> isOrganization { get; set; }
        public Nullable<bool> blocked { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProviderProduct> tblProviderProducts1 { get; set; }
    }
}
