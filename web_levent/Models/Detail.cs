//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_levent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detail()
        {
            this.Orders = new HashSet<Order>();
            this.Size_De1 = new HashSet<Size_De>();
        }
    
        public int ID_Detail { get; set; }
        public Nullable<int> ID_Pro { get; set; }
        public string Name_Pro { get; set; }
        public Nullable<double> Price_Pro { get; set; }
        public string ColorPr_Name { get; set; }
        public string Img_Pro { get; set; }
        public Nullable<byte> size_Pro { get; set; }
        public Nullable<int> Quantity_Pro { get; set; }
    
        public virtual Color_De Color_De { get; set; }
        public virtual Product Product { get; set; }
        public virtual Size_De Size_De { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Size_De> Size_De1 { get; set; }
    }
}
