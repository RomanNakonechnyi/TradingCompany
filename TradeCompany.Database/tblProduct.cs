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
    
    public partial class tblProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProduct()
        {
            this.tblSupplierProducts = new HashSet<tblSupplierProduct>();
        }
    
        public int productId { get; set; }
        public string name { get; set; }
        public Nullable<int> producerId { get; set; }
        public decimal price { get; set; }
        public Nullable<int> categoryId { get; set; }
        public string details { get; set; }
    
        public virtual tblCategory tblCategory { get; set; }
        public virtual tblProducer tblProducer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplierProduct> tblSupplierProducts { get; set; }
    }
}