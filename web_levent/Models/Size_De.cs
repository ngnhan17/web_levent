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
    
    public partial class Size_De
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Size_De()
        {
            this.Details = new HashSet<Detail>();
        }
    
        public int ID_Cate { get; set; }
        public Nullable<int> ID_Details { get; set; }
        public byte Size_Pro { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail> Details { get; set; }
        public virtual Detail Detail { get; set; }
    }
}