//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhatHanhSach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BAOCAODL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAOCAODL()
        {
            this.CT_BAOCAODL = new HashSet<CT_BAOCAODL>();
        }
    
        public int MaBCDL { get; set; }
        public Nullable<int> MaDL { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public Nullable<int> ThanhToan { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual DAILY DAILY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BAOCAODL> CT_BAOCAODL { get; set; }
    }
}
