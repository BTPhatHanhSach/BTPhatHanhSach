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
    
    public partial class CT_PHIEUNHAP
    {
        public int IdPN { get; set; }
        public Nullable<int> MaPN { get; set; }
        public Nullable<int> MaSach { get; set; }
        public Nullable<int> SLNhap { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> ThanhTien { get; set; }
    
        public virtual SACH SACH { get; set; }
        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
    }
}
